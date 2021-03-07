using AssessmentPersistence;
using ProjectHRCommon;
using ProjectHRCommon.DTO;
using ProjectHRCommon.Enum;
using ProjectHRCommon.Extension;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentUserStatusManager : IAssessmentUserStatusManager
    {
        private readonly IAssessmentUserStatusPersistence _assessmentUserStatusPersistence;
        private readonly IAssessmentTemplatePersistence _assessmentTemplatePersistence;
        private readonly IAssessmentScorePersistence _assessmentScorePersistence;
        private readonly IAssessmentAnswersPersistence _assessmentAnswersPersistence;
        private readonly ICrudAssessmentPersistence _crudPersistence;
        private readonly IAssessmentQuestionsPersistence _assessmentQuestionsPersistence;

        public AssessmentUserStatusManager(IAssessmentUserStatusPersistence assessmentUserStatusPersistence, IAssessmentTemplatePersistence assessmentTemplatePersistence,
            IAssessmentScorePersistence assessmentScorePersistence, IAssessmentAnswersPersistence assessmentAnswersPersistence, ICrudAssessmentPersistence crudPersistence, IAssessmentQuestionsPersistence assessmentQuestionsPersistence)
        {

            _assessmentUserStatusPersistence = assessmentUserStatusPersistence;
            _assessmentTemplatePersistence = assessmentTemplatePersistence;
            _assessmentScorePersistence = assessmentScorePersistence;
            _assessmentAnswersPersistence = assessmentAnswersPersistence;
            _crudPersistence = crudPersistence;
            _assessmentQuestionsPersistence = assessmentQuestionsPersistence;
        }

        private async Task<IReadOnlyCollection<UserCommentDetailModel>> GeUserCommentDetails(int id) => await _assessmentUserStatusPersistence.GeUserCommentDetails(id);
        private async Task<bool> GetUserCommentsExistence(int id) => await _assessmentUserStatusPersistence.GetUserCommentsExistence(id);
        private async Task<bool> GetUserChildCommentsExistence(int id) => await _assessmentUserStatusPersistence.GetUserChildCommentsExistence(id);
        private async Task<AssessmentUserStatusLockPinModel> AssessmentUserStatusLockPin(int id) => (await _assessmentUserStatusPersistence.GetAssessmentUserStatusLockPinById(id));


        public async Task<IEnumerable<AssessmentUserStateModel>> GetAll(int roleid, int? assessmentid, string siteCode, int userid)
        {

            if (roleid == 2)//HRM
            {
                var result = await GetByAssessmentId(assessmentid);
                return result.Where(x => x.UserId != userid);

            }
            else if (roleid == 3)//HRBP
            {
                var result = await GetBySiteCode(assessmentid, siteCode);
                return result.Where(x => x.UserId != userid);
            }
            else if (roleid == 4)//MANAGER
            {
                var result = await GetByManagerUserId(assessmentid, (int)userid);
                return result.Where(x => x.UserId != userid);
            }


            throw new System.ArgumentException("Invalid Parameters or Unathorized");
        }

        internal async Task<IEnumerable<AssessmentUserStateModel>> GetByAssessmentId(int? assessmentId)
        {
            return await _assessmentUserStatusPersistence.GetByAssessmentId(assessmentId);
        }

        internal async Task<IEnumerable<AssessmentUserStateModel>> GetByManagerUserId(int? assessmentId, int managerUserId)
        {
            return await _assessmentUserStatusPersistence.GetByManagerUserId(assessmentId, managerUserId);
        }

        internal async Task<IEnumerable<AssessmentUserStateModel>> GetBySiteCode(int? assessmentId, string siteCode)
        {
            return await _assessmentUserStatusPersistence.GetBySiteCode(assessmentId, siteCode);
        }

        public async Task<AssessmentUserStateModel> GetByAssessmentUserStatusId(int id)
        {
            try
            {
                var result = await _assessmentUserStatusPersistence.GetByAssessmentUserStatus(id);

                if (result != null)
                    return result;
                else
                    throw new ArgumentNullException("AssessmentUserStatusId", "Id Not Found");
            }
            catch (Exception)
            {
                throw;
            }
        }



        public async Task<bool> UpdateAssessmentStatus(AssessmentUserStateDTO assessmentUserSateDTO)
        {
            return await _assessmentUserStatusPersistence.UpdateAssessmentStatus(assessmentUserSateDTO);
        }

        public async Task<bool> UpdateAssessmentUserStateClearAnswerIfNotDone(IReadOnlyCollection<AssessmentUserStateDTO> assessmentUserSateDTOs)
        {
            bool response = false;
            List<AssessmentUserStatusModifyByDTO> assessmentUserStatusModifyByList = new List<AssessmentUserStatusModifyByDTO>();
            List<AssessmentUserStateDTO> assessmentUserStateList = new List<AssessmentUserStateDTO>();
            var ids = assessmentUserSateDTOs.Select(x => x.Id).ToList();
            var getAssessementUserStatuses = (await _assessmentUserStatusPersistence.GetAssessmentUserStatusStateByIds(ids));

            if (getAssessementUserStatuses != null)
            {
                foreach (var formStatus in getAssessementUserStatuses)
                {
                    foreach (var dto in assessmentUserSateDTOs)
                    {
                        if (formStatus.StatusId == (int)AssessmentState.NotStarted && dto.StatusId == (int)AssessmentState.Done)
                            return response;
                        else
                        {
                            if (formStatus.StatusId == (int)AssessmentState.Done && dto.StatusId == (int)AssessmentState.Started)
                                assessmentUserStateList.Add(dto);
                            else if ((formStatus.StatusId == (int)AssessmentState.Started || formStatus.StatusId == (int)AssessmentState.Done)
                                && dto.StatusId == (int)AssessmentState.NotStarted)
                            {
                                assessmentUserStateList.Add(dto);
                                assessmentUserStatusModifyByList.Add(new AssessmentUserStatusModifyByDTO()
                                {
                                    Id = dto.Id,
                                    ModifiedBy = dto.ModifiedBy,
                                    StatusId = dto.StatusId
                                });
                            }
                        }
                    }
                }
            }

            if (assessmentUserStateList.Count > 0 || assessmentUserStatusModifyByList.Count > 0)
                response = await _assessmentUserStatusPersistence.UpdateAssessmentStatus(assessmentUserStateList, assessmentUserStatusModifyByList);
            return response;
        }

        public async Task<bool> BulkInsertOrUpdateAssessmentUserStatus(IReadOnlyCollection<AssessmentUserStatusPermissionDTO> assessmentUserStatusDTO)
        {
            var assessmenetTemplates = await _assessmentTemplatePersistence
                 .GetAssessmentTemplateByPermission(assessmentUserStatusDTO
                 .Select(x => x.PermissionId)
                 .ToList());

            var assessmentScores = await _assessmentScorePersistence.GetAll();

            var sssessmentUserStatusDTOs =
                (from dto in assessmentUserStatusDTO.ToList()
                 join template in assessmenetTemplates.ToList()
                    on dto.PermissionId equals template.PermissionId
                 select new AssessmentUserStatusDTO()
                 {
                     ModifyBy = dto.ModifyBy,
                     EmployeeLevelId = assessmentScores
                                       .Where(x => x.ScoreCriteriaId == (int)template.AssessmentTemplateModel.ScoreCriteriaId && x.Name.Contains("N/A"))
                                       .FirstOrDefault().Id,
                     ReportsTo = dto.ReportsTo,
                     SiteCode = dto.SiteCode,
                     Status = (AssessmentState)dto.Status,
                     TemplateId = template.AssessmentTemplateId,
                     UserId = dto.UserId,
                     UserRegionId = dto.UserRegionId
                 })
                 .ToList()
                 .AsReadOnly();

            IReadOnlyCollection<TemplateUserDTO> TemplateUserDTOs = sssessmentUserStatusDTOs.Select(x => new TemplateUserDTO()
            {
                TemplateId = x.TemplateId,
                UserId = x.UserId
            }).ToList().AsReadOnly();

            var getExistingAssessmentUserStatus = await _assessmentUserStatusPersistence.GetAssessmentUserStatusByTemplateAndUser(TemplateUserDTOs);

            var newAssessmentUser = sssessmentUserStatusDTOs
                .Where(x => !getExistingAssessmentUserStatus.Any(ss => ss.UserId == x.UserId && ss.AssessmentTemplateId == x.TemplateId))
                .ToList()
                .AsReadOnly();

            var updateAssessmentUser = sssessmentUserStatusDTOs
               .Where(x => getExistingAssessmentUserStatus.Any(ss => ss.UserId == x.UserId && ss.AssessmentTemplateId == x.TemplateId))
               .ToList()
               .AsReadOnly();



            return false;
        }

        public async Task<bool> UpdateAssessmentStatusTemplate(AssessmentUserStatusTemplateDTO assessmentUserSateDTO)
        {
            return await _assessmentUserStatusPersistence.UpdateAssessmentStatusTemplate(assessmentUserSateDTO);
        }

        public async Task<AssessmentUserStatusStateModel> GetAssessmentUserStatusState(int assessmentUserStatusId)
        {
            return await _assessmentUserStatusPersistence.GetAssessmentUserStatusState(assessmentUserStatusId);
        }

        public async Task<IEnumerable<AssessmentUserStateModel>> GeAssessmentExceptUserInList(int[] userIds, int? permissionId, string siteCode, int? assessmentId)
        {
            return await _assessmentUserStatusPersistence.GeAssessmentExceptUserInList(userIds, permissionId, siteCode, assessmentId);
        }

        public async Task<IReadOnlyCollection<UserFormAndStatusModel>> GetEmployeeFormType(string[] twwids)
        {
            return await _assessmentUserStatusPersistence.GetEmployeeFormType(twwids);
        }

        /* <summary>
            This updates the form of the user to either employee or manager
            if the current form is manager updates it to the latest employee form
            if the current form is employee updates ti to latest manager form
            This updates only 1 active form
            assuming that there will always only be 1 active form
          </summary>
          <param name="userId"></param> 
            userId or twwid of the user to update
          <param name="currentUserId"></param>
            currentUserId userid or twwid of currently logged in user
          <returns>
            GenericHttpResponseMessageModel
            isSuccess if update was successful
            errorCode to be used by angular for matching message
            message short message of error
          </returns>
         */
        public async Task<GenericHttpResponseMessageModel> UpdateForm(UpdateEmployeeFormDTO updateEmployeeFormDTO)
        {
            try
            {


                int currentUserId = updateEmployeeFormDTO.currentUserId;
                //get list of assessment of the user
                var employeeForm = await _assessmentUserStatusPersistence.GetAssessmentUserForm(updateEmployeeFormDTO.userId.ToString(), updateEmployeeFormDTO.actualManagerUserId.ToString());
                var notDoneForms = employeeForm.Where(x => x.StatusId != (int)AssessmentState.Done);

                int UpdatedFormAssessmentId;
                int responseCode = 0;

                /*
                 * list of updated data
                 * assessmentUserStatus, AssessmentTitle, Year, isUpdateSuccess
                 * to be returned to the client for displaying
                 */
                List<object> listOfUpdates = new List<object>();
                List<Task<int>> listOfTasks = new List<Task<int>>();
                int updateSuccessCount = 0;

                if (notDoneForms.Count() > 0)
                {

                    foreach (var form in notDoneForms)
                    {
                        if (form.IsManagerForm != updateEmployeeFormDTO.isManagerForm)
                        {
                            AssessmentTemplateModel newTemplate;
                            if (updateEmployeeFormDTO.isManagerForm)
                            {
                                //4 = PermissionId of Manager
                                //Use permissionId to get the latestForm for Manager
                                newTemplate = _assessmentUserStatusPersistence.GetLatestFormOfPermission(4, form.Year, form.TypeId);

                            }
                            else
                            {
                                //5 = PermissionId of Employee
                                //Use permissionId to get the latestForm for Employee
                                newTemplate = _assessmentUserStatusPersistence.GetLatestFormOfPermission(5, form.Year, form.TypeId);
                            }


                            UpdatedFormAssessmentId = await _assessmentUserStatusPersistence.UpdateForm(form.AssessmentUserStatusId, currentUserId, newTemplate.Id);

                            bool isUpdated = false;
                            if (UpdatedFormAssessmentId > 0)
                            {
                                var isExisting = await _assessmentUserStatusPersistence.GetAssessmentLinkFormIsExist(UpdatedFormAssessmentId);
                                if (isExisting)
                                    await _assessmentUserStatusPersistence.DeleteAssessmentLinkForm(UpdatedFormAssessmentId);

                                isUpdated = true;
                                updateSuccessCount++;
                            }

                            listOfUpdates.Add(new
                            {
                                assessmentUserStatusId = form.AssessmentUserStatusId,
                                templateTitle = newTemplate.Title,
                                templateYear = newTemplate.Year,
                                isUpdated
                            });

                        }
                        else
                        {
                            listOfUpdates.Add(new
                            {
                                assessmentUserStatusId = form.AssessmentUserStatusId,
                                templateTitle = form.FormType,
                                templateYear = form.Year,
                                isUpdated = false
                            });

                        }


                    }

                }

                bool isSuccess = notDoneForms.Count() == updateSuccessCount;

                responseCode = isSuccess ? 2 : 1;
                var response = new GenericHttpResponseMessageModel(
                   isSuccess,
                   Enum.GetName(typeof(AssessmentServiceMessageCodes), responseCode),
                   EnumHelper.GetEnumDescription((AssessmentServiceMessageCodes)responseCode),
                   new
                   {
                       userId = updateEmployeeFormDTO.userId,
                       formsList = listOfUpdates
                   }
                 );


                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IReadOnlyCollection<AssessmentUserStateModel>> GetEmployeeAssessmentDetail(int[] twwids, int? formTypeId)
        {
            return await _assessmentUserStatusPersistence.GetEmployeeAssessmentDetail(twwids, formTypeId);
        }
        public async Task<ResponseModel> GenerateAssessmentUserStatusByAction(AssessmentUserStatusActionLockDTO assessmentUserStatusActionLockDTO)
        {
            ResponseModel responseModel;
            string pinCode = string.Empty;
            bool isLockPinUdpated = false;
            AssessmentUserStatusLockDTO assessmentUserStatusLockDTO = new AssessmentUserStatusLockDTO()
            {
                AssessmentUserStatusId = assessmentUserStatusActionLockDTO.AssessmentUserStatusId,
                LockPinDTO = new LockPinDTO()
                {
                    LockTwwIdDTO = (LockTwwIdDTO)assessmentUserStatusActionLockDTO.TwwId,
                    PinDTO = (PinDTO)assessmentUserStatusActionLockDTO.Pin
                }
            };

            var getAssessmentUserStatusLockPin = (await AssessmentUserStatusLockPin(assessmentUserStatusActionLockDTO.AssessmentUserStatusId));

            switch (assessmentUserStatusActionLockDTO.Action.ToLower())
            {
                case "generate":

                    if (getAssessmentUserStatusLockPin.LockTwwId == 0) // generate only if no lock user
                    {

                        pinCode = AssessmentHelper.GeneratePin(6);
                        assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin = pinCode;
                        isLockPinUdpated = await _assessmentUserStatusPersistence.UpdateAssessmentUserLockPin(assessmentUserStatusLockDTO);
                        if (isLockPinUdpated)
                            responseModel = new ResponseModel($"New pin was created for {assessmentUserStatusActionLockDTO.TwwId}.", true,
                                   new AssessmentUserStatusLockPinModel(assessmentUserStatusLockDTO.AssessmentUserStatusId, assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId,
                                   pinCode));
                        else
                            responseModel = new ResponseModel("There something wrong when updating the Pin and LockedToUser.", false, null);
                    }
                    else
                        responseModel = new ResponseModel("Undefined.", false, null);

                    break;

                case "retrieve":

                    if (getAssessmentUserStatusLockPin != null && (getAssessmentUserStatusLockPin.LockTwwId == assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId || getAssessmentUserStatusLockPin.LockTwwId == 0))
                        responseModel = new ResponseModel("Success!.", true, getAssessmentUserStatusLockPin);
                    else
                        responseModel = new ResponseModel("Undefined.", false, null);
                    break;

                case "resetlockpin":

                    if (getAssessmentUserStatusLockPin == null || getAssessmentUserStatusLockPin.Pin != assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin)
                        return responseModel = new ResponseModel("Undefined.", false, null);
                    else
                    {
                        assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin = string.Empty;
                        assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId = 0;
                        isLockPinUdpated = await _assessmentUserStatusPersistence.UpdateAssessmentUserLockPin(assessmentUserStatusLockDTO);

                        if (isLockPinUdpated)
                            responseModel = new ResponseModel($"Pin and Lock has been reset.", true,
                                    new AssessmentUserStatusLockPinModel(assessmentUserStatusLockDTO.AssessmentUserStatusId, assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId,
                                    pinCode));
                        else
                            responseModel = new ResponseModel("Undefined.", false, null);
                    }
                    break;
                case "validatepin":

                    if (getAssessmentUserStatusLockPin != null && getAssessmentUserStatusLockPin.Pin == assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin)
                    {
                        responseModel = new ResponseModel($"Pin verified.", true,
                               new AssessmentUserStatusLockPinModel(assessmentUserStatusLockDTO.AssessmentUserStatusId, getAssessmentUserStatusLockPin.LockTwwId,
                               getAssessmentUserStatusLockPin.Pin));
                    }
                    else
                        responseModel = new ResponseModel("Undefined.", false, null);
                    break;

                case "validate":

                    if (getAssessmentUserStatusLockPin != null && (getAssessmentUserStatusLockPin.Pin == assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin || string.IsNullOrEmpty(getAssessmentUserStatusLockPin.Pin)))
                    {
                        pinCode = AssessmentHelper.GeneratePin(6);
                        assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin = pinCode;
                        isLockPinUdpated = await _assessmentUserStatusPersistence.UpdateAssessmentUserLockPin(assessmentUserStatusLockDTO);
                        if (isLockPinUdpated)
                            responseModel = new ResponseModel($"Pin was validated and New Pin was created for {assessmentUserStatusActionLockDTO.TwwId}.", true,
                                    new AssessmentUserStatusLockPinModel(assessmentUserStatusLockDTO.AssessmentUserStatusId, assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId,
                                    pinCode));
                        else
                            responseModel = new ResponseModel("Undefined.", false, null);

                    }
                    else
                        responseModel = new ResponseModel("Undefined.", false, null);
                    break;
                default:
                    responseModel = new ResponseModel("Action is undefined.", false, null);
                    break;
            }

            return responseModel;
        }

        public async Task<bool> ResetLockAndPinByAssessmentUserStatusIds(IReadOnlyCollection<int> assessmentUserStatusIds)
        {
            return (await _assessmentUserStatusPersistence.ResetLockAndPinByAssessmentUserStatusIds(assessmentUserStatusIds));
        }

        public async Task<IReadOnlyCollection<int>> GetAssessmentUserFormLockToAssistingManager(int twwid, int LockedToTwwIdId)
        {
            return (await _assessmentUserStatusPersistence.GetAssessmentUserFormLockToAssistingManager(twwid, LockedToTwwIdId));
        }

        public async Task<IReadOnlyCollection<AssessmentUserFormModel>> GetAssessmentUserForm(UserManagerDTO userManagerDTO)
        {
            return (await _assessmentUserStatusPersistence.GetAssessmentUserForm(userManagerDTO.TwwId, userManagerDTO.ActualManagerTwwId));
        }

        public async Task<IReadOnlyCollection<AssessmentUserCompletedFormModel>> GetAssessmentUserCompletedForms(int userId)
        {
            return (await _assessmentUserStatusPersistence.GetAssessmentUserCompletedForms(userId));
        }

        public async Task<IReadOnlyCollection<AssessmentUserCommentsModel>> GetAssessmentUserComments(AssessmentUserStatusCategoryDTO assessmentUserStatusCategoryDTO)
        {
            int parentId = 0;
            var userComments = await _assessmentUserStatusPersistence.GetAssessmentUserComments(assessmentUserStatusCategoryDTO);


            var parentuserComments = userComments.Where(x => x.ParentId == parentId);
            List<AssessmentUserCommentsModel> assessmentUserCommentsList = new List<AssessmentUserCommentsModel>();

            foreach (var parentuserComment in parentuserComments)
            {
                int currentParent = parentuserComment.Id;

                var getChildComments = userComments.Where(x => x.ParentId != parentId && x.ParentId == currentParent).OrderBy(x => x.ModifiedDateTime).ToList();
                assessmentUserCommentsList.Add(new AssessmentUserCommentsModel(parentuserComment, getChildComments));
            }

            return assessmentUserCommentsList.AsReadOnly();
        }

        public async Task<ResponseModel> InsertAssessmentUserComment(AssessmentUserCommentDTO assessmentUserCommentDTO)
        {
            DateTime dtUtc = DateTime.UtcNow;

            var dto = new AssessmentUserStatusCommentDTO()
            {
                AssessmentUserStatusId = assessmentUserCommentDTO.AssessmentUserStatusId,
                CategoryCode = assessmentUserCommentDTO.CategoryCode,
                TwwId = assessmentUserCommentDTO.TwwId,
                Comments = assessmentUserCommentDTO.Comments,
                CreatedDateTime = dtUtc,
                ModifiedDateTime = dtUtc,
                IsEdited = false,
                ParentId = assessmentUserCommentDTO.ParentId
            };

            var userComments = await _assessmentUserStatusPersistence.InsertAssessmentUserCommentModel(dto);
            return new ResponseModel("Success!.", true, userComments);
        }

        public async Task<ResponseModel> DeleteAssessmentUserComment(int AssessmentUserCommentId)
        {

            bool isChildCommentExist = await GetUserChildCommentsExistence(AssessmentUserCommentId);
            if (isChildCommentExist)
                return new ResponseModel("Failed! cannot delete comment with replies.", false, null);
            else
            {
                bool isCommentExist = await GetUserCommentsExistence(AssessmentUserCommentId);
                if (!isCommentExist)
                    return new ResponseModel("Failed! cannot delete, comment is not exist.", false, null);
                else
                {
                    var result = await _crudPersistence.Delete(AssessmentUserCommentId);
                    if (result > 0)
                        return new ResponseModel("Success!.", true, null);
                    else
                        return new ResponseModel("Failed! there something wrong in DeleteAssessmentUserComment().", false, null);
                }
            }

        }

        public async Task<ResponseModel> UpdateComment(AssessmentUserCommentUpdateDTO assessmentUserCommentUpdateDTO)
        {
            bool isCommentExist = await GetUserCommentsExistence(assessmentUserCommentUpdateDTO.Id);
            if (!isCommentExist)
                return new ResponseModel("Failed! cannot update, comment is not exist.", false, null);
            else
            {
                DateTime dtUtc = DateTime.UtcNow;
                var assessmentUserComment = new AssessmentUserStatusCommentDTO()
                {
                    Id = assessmentUserCommentUpdateDTO.Id,
                    IsEdited = true,
                    ModifiedDateTime = dtUtc,
                    Comments = assessmentUserCommentUpdateDTO.Comments
                };

                var result = await _crudPersistence.Update(assessmentUserComment);
                if (result != null)
                    return new ResponseModel("Success!.", true, result);
                else
                    return new ResponseModel("Failed! there something wrong in UpdateComment().", false, null);
            }
            throw new NotImplementedException();
        }

        public async Task<ResponseModel> InsertAssessmentLinkForm(AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            var insertModel = await _assessmentUserStatusPersistence.InsertAssessmentLinkForm(assessmentLinkFormDTO);
            bool isSuccess = (insertModel != null ? true : false);
            return new ResponseModel("Insert executed.", isSuccess, insertModel);
        }

        public async Task<bool> DeleteAssessmentLinkFormById(int id)
        {
            var deletedCount = await _assessmentUserStatusPersistence.DeleteAssessmentLinkFormById(id);
            return (deletedCount > 0);
        }

        public async Task<bool> DeleteAssessmentLinkForm(int assessmentUserStatusId)
        {
            var deletedCount = await _assessmentUserStatusPersistence.DeleteAssessmentLinkForm(assessmentUserStatusId);
            return (deletedCount > 0);
        }

        public async Task<ResponseModel> UpdateAssessmentLinkForm(int id, AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            var updateModel = await _assessmentUserStatusPersistence.UpdateAssessmentLinkForm(id, assessmentLinkFormDTO);
            bool isSuccess = (updateModel != null ? true : false);
            return new ResponseModel("Insert executed.", isSuccess, updateModel);
        }

        /// <summary>
        /// Delete Answer that doesn't have an equivalent 
        /// CategoryCode, QuestionCode, DomId in templateQuestions
        /// this may be caused by updating the AssessmenTemplateId to new version
        /// and some questions are not included in the new Template
        /// when this happens we Delete the Answers made in the old questions
        /// after deleting update the AssessmentUserStatus.TemplateId to latestTemplateId
        /// </summary>
        /// <param name="AssessmentUserStatusTemplateDTO">
        /// AssessmentUserStatusId - id of recording going to be updated
        /// TemplateId - TemplateId of the new version
        /// ModifyBy - TWWID of current logged in user
        /// </param>
        /// <returns>
        /// true - if delete and update of assessmentTemaplte is successfull
        /// or latestTemplateId == currentAssessmentTemplateId
        /// false - if latestTemplateId == 0
        /// </returns>
        public async Task<bool> UpdateTemplateToNewVersion(AssessmentUserStatusTemplateDTO assessmentUserStatusTemplateDTO)
        {
            try
            {
                int assessmentUserStatusId = assessmentUserStatusTemplateDTO.AssessmentUserStatusId;
                int currentAssessmentTemplateId = await _assessmentUserStatusPersistence.GetAssessmentTemplateIdById(assessmentUserStatusId);
                int newVersionTemplateId = await _assessmentTemplatePersistence.GetLatestVersionById(currentAssessmentTemplateId);

                if (assessmentUserStatusTemplateDTO.TemplateId != newVersionTemplateId || currentAssessmentTemplateId == 0 || newVersionTemplateId == 0)
                    return false;
                if (newVersionTemplateId == currentAssessmentTemplateId)
                    return true;
                else if (newVersionTemplateId != 0 && newVersionTemplateId != currentAssessmentTemplateId)
                {
                    var templateQuestions = await _assessmentQuestionsPersistence.GetTemplateQuestionnaire(newVersionTemplateId);
                    var templateQuestionCodesForAnswer = templateQuestions.QuestionnaireModel
                        .SelectMany(template =>
                            template.Questions.SelectMany(question =>
                                question.DomList.Where(dom => dom.ForAnswer == true)
                                    .Select(dom => new
                                    {
                                        question.CategoryCode,
                                        question.QuestionCode,
                                        dom.DomId
                                    })
                        ));

                    var answers = await _assessmentAnswersPersistence.GetAnswers(assessmentUserStatusId);
                    var answerQuestionCode = answers.AnswersModels
                        .Select(x => new
                        {
                            x.Id,
                            answerQuestionCodes = new
                            {
                                x.CategoryCode,
                                x.QuestionCode,
                                x.DomId,
                            }
                        });

                    //remove item in answers that doesn't have an equivalent in templateQuestions
                    var nonExistentAnswerId = answerQuestionCode
                        .Except(templateQuestionCodesForAnswer, a => a.answerQuestionCodes, q => q)
                        .Select(x => x.Id)
                        .ToArray();

                    var isDeleted = await _assessmentAnswersPersistence.DeleteAnswers(nonExistentAnswerId);
                    if (isDeleted)
                    {
                        assessmentUserStatusTemplateDTO.TemplateId = newVersionTemplateId;
                        var isAssessmentTemplateUpdated = await _assessmentUserStatusPersistence.UpdateAssessmentStatusTemplate(assessmentUserStatusTemplateDTO);

                        return isAssessmentTemplateUpdated;
                    }
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
