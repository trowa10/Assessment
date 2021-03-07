using AssessmentPersistence;
using ProjectHRCommon.Constants;
using ProjectHRCommon.DTO;
using ProjectHRCommon.Enum;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentQuestionnaireManager : IAssessmentQuestionnaireManager
    {
        private readonly IAssessmentAnswersPersistence _assessmentAnswersPersistence;
        private readonly IAssessmentQuestionsPersistence _assessmentQuestionsPersistence;
        private readonly IAssessmentUserStatusPersistence _assessmentUserStatusPersistence;
        private readonly IAssessmentScorePersistence _assessmentScorePersistence;
        private readonly IAssessmentTemplatePersistence _assessmentTemplatePersistence;

        public AssessmentQuestionnaireManager(IAssessmentAnswersPersistence assessmentAnswersPersistence,
            IAssessmentQuestionsPersistence assessmentQuestionsPersistence, IAssessmentUserStatusPersistence assessmentUserStatusPersistence,
            IAssessmentScorePersistence assessmentScorePersistence,
            IAssessmentTemplatePersistence assessmentTemplatePersistence)
        {
            _assessmentAnswersPersistence = assessmentAnswersPersistence;
            _assessmentQuestionsPersistence = assessmentQuestionsPersistence;
            _assessmentUserStatusPersistence = assessmentUserStatusPersistence;
            _assessmentScorePersistence = assessmentScorePersistence;
            _assessmentTemplatePersistence = assessmentTemplatePersistence;
        }
        public async Task<AssessmentAnswersModel> GetAnswers(int assessmentUserStatusId)
        {
            var result = await _assessmentAnswersPersistence.GetAssessmentAnswers(assessmentUserStatusId);

            if (result == null)
            {
                var newAnswer = new AssessmentAnswersModel(
                    assessmentUserStatusId,
                    0,
                    "",
                    null,
                    null,
                    null,
                    0,
                    null
                    );

                return newAnswer;
            }
            else
            {
                AssessmentAnswersModel newAnswer = new AssessmentAnswersModel(
                        result.AssessmentUserStatusId,
                        result.TotalScore,
                        result.AnswersJson,
                        result.DateManagerApproved,
                        result.DateEmployeeApproved,
                        (string.IsNullOrEmpty(result.LanguageCode) == true ? "sv" : result.LanguageCode),
                        result.ApproverTwwId,
                        result.DateTimeSubmitted
                   );
                return newAnswer;
            }
        }

        //v2
        public async Task<AssessmentAnswersModel> GetAssessmentAnswers(int assessmentUserStatusId)
        {
            var result = await _assessmentAnswersPersistence.GetAnswers(assessmentUserStatusId);

            if (result == null)
            {
                return new AssessmentAnswersModel(
                    assessmentUserStatusId,
                    0,
                    "",
                    null,
                    null,
                    null,
                    0,
                    null
                    );
            }

            AssessmentAnswersModel assessmentAnswer = new AssessmentAnswersModel(
                    result.AssessmentUserStatusId,
                    result.TotalScore,
                    result.DateManagerApproved,
                    result.DateEmployeeApproved,
                    (string.IsNullOrEmpty(result.LanguageCode) == true ? "sv" : result.LanguageCode),
                    result.ApproverTwwId,
                    result.DateTimeSubmitted,
                    result.AnswersModels
               );

            return assessmentAnswer;

        }

        public async Task<TemplateScoreCriteriaModel> GeTemplateScoreCriteria(int assessmentTemplateId)
        {
            var templateDetail = await _assessmentTemplatePersistence.GetAssessmentTemplate(assessmentTemplateId);

            return new TemplateScoreCriteriaModel(templateDetail.Id, (ScoreCriteria)templateDetail.ScoreCriteriaId);
        }

        public async Task<AssessmentQuestionsModel> GetQuestionnaireByTemplateId(int assessmentTemplateId)
        {
            var result = await _assessmentQuestionsPersistence.GetAssessmentQuestions(assessmentTemplateId);

            if (result == null)
                throw new System.ArgumentNullException("AssessmentQuestionsNull", "No Result found in Assessment Questions for provided Assessment Template Id.");

            return result;

        }

        //v1
        public async Task<AssessmentQuestionnaireDetailModel> GetAssessmentQuestionnaireDetail(int assessmentUserStatusId, int userId, bool isNoLocked = false)
        {

            try
            {
                AssessmentUserStateModel userStatus = await _assessmentUserStatusPersistence.GetByAssessmentUserStatus(assessmentUserStatusId);

                if (userStatus == null)
                    throw new ArgumentNullException("AssessmentUserStatusNull", "No Result found.");
                if (userStatus.LockedToUserId == userId || userStatus.Status.ToLower() == "done" || userStatus.LockedToUserId == 0 || !userStatus.IsAvailable || isNoLocked) //isNoLocked == true ignore all validations
                {

                    if (!userStatus.IsAvailable && userStatus.LockedToUserId != 0 && isNoLocked == false)
                    {
                        int[] ids = new int[] { userStatus.Id };
                        await _assessmentUserStatusPersistence.ResetLockAndPinByAssessmentUserStatusIds(ids);
                    }

                    var templateScore = await GeTemplateScoreCriteria(userStatus.AssessmentTemplateId);
                    IEnumerable<ScoreModel> scores = await _assessmentScorePersistence.Get((int)templateScore.ScoreCriteriaId);

                    Task<AssessmentQuestionsModel> assessmentQuestionsModelTask = GetQuestionnaireByTemplateId(userStatus.AssessmentTemplateId);
                    Task<AssessmentAnswersModel> assessmentAnswersModelTask = GetAnswers(userStatus.Id);
                    Task<AssessmentTemplateTypeModel> assessmentTemplateTypeModelTask = AssessmentTemplateTypeModel(userStatus.AssessmentTemplateId);
                    Task<IReadOnlyCollection<UserCommentAvailabilityModel>> userCommentAvailabilitysTask = UserCommentAvailability(assessmentUserStatusId);

                    await Task.WhenAll(assessmentQuestionsModelTask, assessmentAnswersModelTask, assessmentTemplateTypeModelTask,
                        userCommentAvailabilitysTask);

                    AssessmentQuestionsModel assessmentQuestionsModel = await assessmentQuestionsModelTask;
                    AssessmentAnswersModel assessmentAnswersModel = await assessmentAnswersModelTask;
                    AssessmentTemplateTypeModel assessmentTemplateTypeModel = await assessmentTemplateTypeModelTask;
                    IReadOnlyCollection<UserCommentAvailabilityModel> UserCommentAvailabilityModels = await userCommentAvailabilitysTask;
                    var assessmentLinkFormDetail = await GetAssessmentFromLinkFormDetail(assessmentUserStatusId);

                    AssessmentQuestionnaireDetailModel result = new AssessmentQuestionnaireDetailModel(
                        userStatus,
                        assessmentQuestionsModel,
                        assessmentAnswersModel,
                        scores,
                        assessmentTemplateTypeModel,
                        UserCommentAvailabilityModels,
                        assessmentLinkFormDetail
                        );

                    return result;
                }
                //if current UserId is the reports to of user and the status is not done then throw error to prompt unauthorized
                throw new ArgumentException("You don't have access to this page.", "InvalidUser");
            }
            catch (ArgumentNullException ex)
            {
                switch (ex.ParamName)
                {
                    //handle custom exception but just rethrow for now if need custom params and message update this.
                    case "AssessmentUserStatusNull":
                        throw;
                    case "AssessmentAnswerNull":
                        throw;
                    case "AssessmentQuestionsNull":
                        throw;
                    case "AssessmentTemplateTypeNull":
                        throw;
                    default:
                        return null;
                }
            }
        }
        //v1
        public async Task<ResponseModel> UpsertAnswers(AssessmentAnswerDTO assessmentAnswerDTO)
        {
            ResponseModel response;
            bool isAutoSave = false;
            int assessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;

            //check if assessment is available
            response = await InsertUpdateAnswers(assessmentAnswerDTO, isAutoSave);
            int templateScoreCriteriaId = await _assessmentUserStatusPersistence.GetAssessmentTemplateScoreCriteriaByUserStateId(assessmentUserStatusId);


            //after updating answer update level and and status
            var employeeLevelAndStatus = new AssessmentStatusAndLevelDTO
            {
                Id = assessmentUserStatusId,
                EmployeeLevelId = await _assessmentScorePersistence.CalculateEmployeeLevel(assessmentAnswerDTO.TotalScore, templateScoreCriteriaId),
                StatusId = assessmentAnswerDTO.StatusId,
                ModifiedBy = assessmentAnswerDTO.ModifiedBy
            };

            if (response.IsSuccess) //submit or draft success
            {
                //Clear lock and Pin
                AssessmentUserStatusLockDTO assessmentUserStatusLockDTO = new AssessmentUserStatusLockDTO()
                {
                    AssessmentUserStatusId = assessmentUserStatusId,
                    LockPinDTO = new LockPinDTO()
                    {
                        LockTwwIdDTO = (LockTwwIdDTO)0,
                        PinDTO = (PinDTO)string.Empty
                    }
                };

                await _assessmentUserStatusPersistence.UpdateStatusAndEmployeeLevel(employeeLevelAndStatus, assessmentUserStatusLockDTO);
            }

            return response;
        }

        //v2
        public async Task<ResponseModel> UpsertAnswers_v2(AssessmentAnswerDTO assessmentAnswerDTO)
        {
            ResponseModel response;
            bool isAutoSave = false;
            int assessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;

            //check if assessment is available
            response = await InsertUpdateAnswers_v2(assessmentAnswerDTO, isAutoSave);
            int templateScoreCriteriaId = await _assessmentUserStatusPersistence.GetAssessmentTemplateScoreCriteriaByUserStateId(assessmentUserStatusId);


            //after updating answer update level and and status
            var employeeLevelAndStatus = new AssessmentStatusAndLevelDTO
            {
                Id = assessmentUserStatusId,
                EmployeeLevelId = await _assessmentScorePersistence.CalculateEmployeeLevel(assessmentAnswerDTO.TotalScore, templateScoreCriteriaId),
                StatusId = assessmentAnswerDTO.StatusId,
                ModifiedBy = assessmentAnswerDTO.ModifiedBy
            };

            if (response.IsSuccess) //submit or draft success
            {
                //Clear lock and Pin
                AssessmentUserStatusLockDTO assessmentUserStatusLockDTO = new AssessmentUserStatusLockDTO()
                {
                    AssessmentUserStatusId = assessmentUserStatusId,
                    LockPinDTO = new LockPinDTO()
                    {
                        LockTwwIdDTO = (LockTwwIdDTO)0,
                        PinDTO = (PinDTO)string.Empty
                    }
                };

                await _assessmentUserStatusPersistence.UpdateStatusAndEmployeeLevel(employeeLevelAndStatus, assessmentUserStatusLockDTO);
            }

            return response;
        }

        public async Task<AssessmentQuestionsModel> GetQuestionnaireByTemplateLanguage(AssessmentLanguageDTO assessmentLanguageDTO)
        {
            return await _assessmentQuestionsPersistence.GetAssessmentQuestions(assessmentLanguageDTO.TemplateId, assessmentLanguageDTO.LanguageCode);
        }

        public async Task<int> GetTemplateLatestVersion(int assessmentUserStatusId)
        {
            try
            {
                int assessmentTemplateId = await _assessmentUserStatusPersistence.GetAssessmentTemplateIdById(assessmentUserStatusId);
                int latestVersion = await _assessmentTemplatePersistence.GetLatestVersionById(assessmentTemplateId);

                return latestVersion;
            }
            catch (Exception)
            {

                return 0;
                throw;
            }

        }

        public async Task<ResponseModel> AutoUpsertAnswers(AssessmentAnswerDTO assessmentAnswerDTO)
        {
            ResponseModel response;
            bool isAutoSave = true;
            int assessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;

            response = await InsertUpdateAnswers(assessmentAnswerDTO, isAutoSave);
            int templateScoreCriteriaId = await _assessmentUserStatusPersistence.GetAssessmentTemplateScoreCriteriaByUserStateId(assessmentUserStatusId);


            if (response.IsSuccess) //submit or draft success
            {
                //after updating answer update level and and status
                var employeeLevelAndStatus = new AssessmentStatusAndLevelDTO
                {
                    Id = assessmentUserStatusId,
                    EmployeeLevelId = await _assessmentScorePersistence.CalculateEmployeeLevel(assessmentAnswerDTO.TotalScore, templateScoreCriteriaId),
                    StatusId = assessmentAnswerDTO.StatusId,
                    ModifiedBy = assessmentAnswerDTO.ModifiedBy
                };
                await _assessmentUserStatusPersistence.UpdateStatusAndEmployeeLevel(employeeLevelAndStatus);
            }

            return response;
        }

        public async Task<ResponseModel> AutoUpsertAnswers_v2(AssessmentAnswerDTO assessmentAnswerDTO)
        {
            ResponseModel response;
            bool isAutoSave = true;
            int assessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;

            response = await InsertUpdateAnswers_v2(assessmentAnswerDTO, isAutoSave);
            int templateScoreCriteriaId = await _assessmentUserStatusPersistence.GetAssessmentTemplateScoreCriteriaByUserStateId(assessmentUserStatusId);


            if (response.IsSuccess) //submit or draft success
            {
                //after updating answer update level and and status
                var employeeLevelAndStatus = new AssessmentStatusAndLevelDTO
                {
                    Id = assessmentUserStatusId,
                    EmployeeLevelId = await _assessmentScorePersistence.CalculateEmployeeLevel(assessmentAnswerDTO.TotalScore, templateScoreCriteriaId),
                    StatusId = assessmentAnswerDTO.StatusId,
                    ModifiedBy = assessmentAnswerDTO.ModifiedBy
                };
                await _assessmentUserStatusPersistence.UpdateStatusAndEmployeeLevel(employeeLevelAndStatus);
            }

            return response;
        }

        private async Task<AssessmentTemplateTypeModel> AssessmentTemplateTypeModel(int assessmentTemplateId)
        {
            var result = await _assessmentTemplatePersistence.GetAssessmentTemplateType(assessmentTemplateId);

            if (result == null)
                throw new System.ArgumentNullException("AssessmentTemplateTypeNull", "No Result found in Assessment Template Type for provided Assessment Template Id.");

            return result;
        }

        private async Task<IReadOnlyCollection<UserCommentAvailabilityModel>> UserCommentAvailability(int assessmentUserStatusId)
        {
            return await _assessmentUserStatusPersistence.GetUserCommentAvailability(assessmentUserStatusId);
        }

        private async Task<AssessmentLinkFormDetailModel> GetAssessmentFromLinkFormDetail(int assessmentUserStatusId)
            => await _assessmentUserStatusPersistence.GetAssessmentFromLinkFormDetail(assessmentUserStatusId);

        //v1
        private async Task<ResponseModel> InsertUpdateAnswers(AssessmentAnswerDTO assessmentAnswerDTO, bool isAutoSave)
        {
            ResponseModel response;
            string message = string.Empty;
            bool isSuccess = false;
            int assessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;

            //check if assessment is available
            bool isAssessmentAvailable = await _assessmentUserStatusPersistence.IsAssessmentAvailable(assessmentUserStatusId);
            bool isLockedToUser = await _assessmentUserStatusPersistence.GetAssessmentUserStatusIsLocked(assessmentUserStatusId, assessmentAnswerDTO.LockedToTwwId);
            bool isAnswerIdExists = await _assessmentAnswersPersistence.IsAnswerIdExists(assessmentUserStatusId);

            if (!isLockedToUser)
                return new ResponseModel("This form is currently not available to you.", isLockedToUser, null);

            if (!isAssessmentAvailable)
                return new ResponseModel("You're trying to update an inactive Assessment", isAssessmentAvailable, null);

            var assessmentUserAnswer = new AssessmentUserAnswerDTO()
            {
                AnswersJson = assessmentAnswerDTO.AnswersJson,
                ApproverTwwId = assessmentAnswerDTO.ApproverTwwId,
                AssessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId,
                DateEmployeeApproved = assessmentAnswerDTO.DateEmployeeApproved,
                DateManagerApproved = assessmentAnswerDTO.DateManagerApproved,
                EmployeeLevelId = assessmentAnswerDTO.EmployeeLevelId,
                LanguageCode = assessmentAnswerDTO.LanguageCode,
                ModifiedBy = assessmentAnswerDTO.ModifiedBy,
                StatusId = assessmentAnswerDTO.StatusId,
                TotalScore = assessmentAnswerDTO.TotalScore,
                ShowEmpLevel = assessmentAnswerDTO.ShowEmpLevel

            };

            if (isAutoSave)
                message = "Your changed has been saved.";
            else
                message = "Your changed has been saved/submitted.";

            if (isAnswerIdExists)
            {
                isSuccess = await _assessmentAnswersPersistence.UpdateAnswer(assessmentUserAnswer);
                response = new ResponseModel(message, isSuccess, null);
            }
            else
            {
                isSuccess = await _assessmentAnswersPersistence.InsertAnswer(assessmentUserAnswer);
                response = new ResponseModel(message, isSuccess, null);
            }

            return response;
        }

        //v2
        private async Task<ResponseModel> InsertUpdateAnswers_v2(AssessmentAnswerDTO assessmentAnswerDTO, bool isAutoSave)
        {
            ResponseModel response;
            string message = string.Empty;
            bool isSuccess = false;
            int assessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId;

            //check if assessment is available
            bool isAssessmentAvailable = await _assessmentUserStatusPersistence.IsAssessmentAvailable(assessmentUserStatusId);
            bool isLockedToUser = await _assessmentUserStatusPersistence.GetAssessmentUserStatusIsLocked(assessmentUserStatusId, assessmentAnswerDTO.LockedToTwwId);
            bool isAnswerIdExists = await _assessmentAnswersPersistence.IsAnswerIdExists(assessmentUserStatusId);

            if (!isLockedToUser)
                return new ResponseModel("This form is currently not available to you.", isLockedToUser, null);

            if (!isAssessmentAvailable)
                return new ResponseModel("You're trying to update an inactive Assessment", isAssessmentAvailable, null);

            var assessmentUserAnswer = new AssessmentUserAnswerDTO()
            {
                AnswersJson = assessmentAnswerDTO.AnswersJson,
                ApproverTwwId = assessmentAnswerDTO.ApproverTwwId,
                AssessmentUserStatusId = assessmentAnswerDTO.AssessmentUserStatusId,
                DateEmployeeApproved = assessmentAnswerDTO.DateEmployeeApproved,
                DateManagerApproved = assessmentAnswerDTO.DateManagerApproved,
                EmployeeLevelId = assessmentAnswerDTO.EmployeeLevelId,
                LanguageCode = assessmentAnswerDTO.LanguageCode,
                ModifiedBy = assessmentAnswerDTO.ModifiedBy,
                StatusId = assessmentAnswerDTO.StatusId,
                TotalScore = assessmentAnswerDTO.TotalScore,
                ShowEmpLevel = assessmentAnswerDTO.ShowEmpLevel,
                Answers = assessmentAnswerDTO.Answers

            };

            if (isAutoSave)
                message = "Your changed has been saved.";
            else
                message = "Your changed has been saved/submitted.";

            if (isAnswerIdExists)
            {
                isSuccess = await _assessmentAnswersPersistence.UpdateAnswer_v2(assessmentUserAnswer);
                response = new ResponseModel(message, isSuccess, null);
            }
            else
            {
                isSuccess = await _assessmentAnswersPersistence.InsertAnswer_v2(assessmentUserAnswer);
                response = new ResponseModel(message, isSuccess, null);
            }

            return response;
        }


        //For API Version 2

        public async Task<AssessmentQuestionsModel> GetTemplateQuestionnaireByTemplateId(int assessmentTemplateId, string languageCode = Globals.DEFAULT_LANGUAGE_CODE)
        {
            languageCode = languageCode ?? Globals.DEFAULT_LANGUAGE_CODE;

            var result = await _assessmentQuestionsPersistence.GetTemplateQuestionnaire(assessmentTemplateId, languageCode);

            if (result == null)
                throw new System.ArgumentNullException("AssessmentQuestionsNull", "No Result found in Assessment Questions for provided Assessment Template Id.");

            return result;

        }

        //v2
        public async Task<AssessmentQuestionnaireDetailModel> GetAssessmentQuestionnaireDetail_v2(int assessmentUserStatusId, int userId, bool isNoLocked = false)
        {

            try
            {
                AssessmentUserStateModel userStatus = await _assessmentUserStatusPersistence.GetByAssessmentUserStatus(assessmentUserStatusId);

                if (userStatus == null)
                    throw new ArgumentNullException("AssessmentUserStatusNull", "No Result found.");
                if (userStatus.LockedToUserId == userId || userStatus.Status.ToLower() == "done" || userStatus.LockedToUserId == 0 || !userStatus.IsAvailable || isNoLocked) //isNoLocked == true ignore all validations
                {

                    if (!userStatus.IsAvailable && userStatus.LockedToUserId != 0 && isNoLocked == false)
                    {
                        int[] ids = new int[] { userStatus.Id };
                        await _assessmentUserStatusPersistence.ResetLockAndPinByAssessmentUserStatusIds(ids);
                    }

                    var templateScore = await GeTemplateScoreCriteria(userStatus.AssessmentTemplateId);
                    IEnumerable<ScoreModel> scores = await _assessmentScorePersistence.Get((int)templateScore.ScoreCriteriaId);

                    Task<AssessmentQuestionsModel> assessmentQuestionsModelTask = GetTemplateQuestionnaireByTemplateId(userStatus.AssessmentTemplateId);
                    Task<AssessmentAnswersModel> assessmentAnswersModelTask = GetAssessmentAnswers(userStatus.Id);
                    Task<AssessmentTemplateTypeModel> assessmentTemplateTypeModelTask = AssessmentTemplateTypeModel(userStatus.AssessmentTemplateId);
                    Task<IReadOnlyCollection<UserCommentAvailabilityModel>> userCommentAvailabilitysTask = UserCommentAvailability(assessmentUserStatusId);

                    await Task.WhenAll(assessmentQuestionsModelTask, assessmentAnswersModelTask, assessmentTemplateTypeModelTask,
                        userCommentAvailabilitysTask);

                    AssessmentQuestionsModel assessmentQuestionsModel = await assessmentQuestionsModelTask;
                    AssessmentAnswersModel assessmentAnswersModel = await assessmentAnswersModelTask;
                    AssessmentTemplateTypeModel assessmentTemplateTypeModel = await assessmentTemplateTypeModelTask;
                    IReadOnlyCollection<UserCommentAvailabilityModel> UserCommentAvailabilityModels = await userCommentAvailabilitysTask;
                    var assessmentLinkFormDetail = await GetAssessmentFromLinkFormDetail(assessmentUserStatusId);

                    AssessmentQuestionnaireDetailModel result = new AssessmentQuestionnaireDetailModel(
                        userStatus,
                        assessmentQuestionsModel,
                        assessmentAnswersModel,
                        scores,
                        assessmentTemplateTypeModel,
                        UserCommentAvailabilityModels,
                        assessmentLinkFormDetail
                        );

                    return result;
                }
                //if current UserId is the reports to of user and the status is not done then throw error to prompt unauthorized
                throw new ArgumentException("You don't have access to this page.", "InvalidUser");
            }
            catch (ArgumentNullException ex)
            {
                switch (ex.ParamName)
                {
                    //handle custom exception but just rethrow for now if need custom params and message update this.
                    case "AssessmentUserStatusNull":
                        throw;
                    case "AssessmentAnswerNull":
                        throw;
                    case "AssessmentQuestionsNull":
                        throw;
                    case "AssessmentTemplateTypeNull":
                        throw;
                    default:
                        return null;
                }
            }
        }
    }
}

