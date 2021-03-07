using AssessmentPersistence.Entities;
using AssessmentPersistence.Entities.LookUpTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProjectHRCommon;
using ProjectHRCommon.Abstract;
using ProjectHRCommon.DTO;
using ProjectHRCommon.Enum;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using EScoreCriteria = ProjectHRCommon.Enum.ScoreCriteria;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusPersistence : CrudAbstractClass, IAssessmentUserStatusPersistence, ICrudAssessmentPersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentUserStatusPersistence(DataContext dataContext) : base()
        {
            _dataContext = dataContext;
        }

        private async Task<AssessmentLinkForm> GetAssessmentLinkForm(int id)
        {
            return await _dataContext.AssessmentLinkForms
            .AsNoTracking()
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();
        }

        public async Task<bool> GetAssessmentLinkFormIsExist(int assessmentUserStatusId)
        {
            return await _dataContext.AssessmentLinkForms
            .AsNoTracking()
            .Where(x => x.AssessmentUserstatusId == assessmentUserStatusId)
            .AnyAsync();
        }

        private async Task<AssessmentUserStatus> GetAssessmentUserStatusById(int id)
        {

            return await _dataContext.AssessmentUserStatus
            .AsNoTracking()
            .Where(x =>
                x.IsActive == true
                && x.Id == id)
            .FirstOrDefaultAsync();
        }

        private async Task<IReadOnlyCollection<AssessmentUserStatus>> GetAssessmentUserStatusByIds(List<int> ids)
        {
            return await _dataContext.AssessmentUserStatus
            .AsNoTracking()
            .Where(x => ids.Contains(x.Id) && x.IsActive == true)
            .ToListAsync();
        }

        private async Task<AssessmentAnswer> GetAssessmentAnswerByAssessmentUserStatusById(int id)
        {
            return await _dataContext.AssessmentAnswers
                .Include(x => x.AssessmentUserStatus)
                .AsNoTracking()
                .Where(x =>
                    x.AssessmentUserStatus.IsActive == true
                    && x.AssessmentUserStatus.Id == id)
                .FirstOrDefaultAsync();
        }

        private async Task<AssessmentUserComment> GetUserComment(int id)
        {
            return await _dataContext.AssessmentUserComments
             .AsNoTracking()
             .Where(x => x.Id == id)
             .FirstOrDefaultAsync();
        }

        private async Task<IReadOnlyCollection<UserAnswerTotalScoreModel>> GetUserAnswerTotalScores(IReadOnlyCollection<int> assessmentUserStatusIds)
        {
            return await _dataContext.AssessmentAnswers
             .AsNoTracking()
             .Where(x => assessmentUserStatusIds.Contains(x.AssessmentUserStatusId))
             .Select(x => new UserAnswerTotalScoreModel(x.Id, x.AssessmentUserStatusId, x.TotalScore, x.ShowEmpLevel))
             .ToListAsync();
        }

        private IReadOnlyCollection<AssessmentUserStateModel> GetAssessmentUserScoreModel(
            IReadOnlyCollection<AssessmentUserStatus> assessmentUserStatuses,
            IReadOnlyCollection<UserAnswerTotalScoreModel> userAnswerTotalScoreModels)
        {

            var result = (from assessmentsUserStatus in assessmentUserStatuses
                          join assessmentUserScore in userAnswerTotalScoreModels
                            on assessmentsUserStatus.Id equals assessmentUserScore.AssessmentUserStatusId
                               into userScores
                          from assessmentUserScore in userScores.DefaultIfEmpty()
                          select new AssessmentUserStateModel(
                                    assessmentsUserStatus.Id,
                                    assessmentsUserStatus.UserId,
                                    assessmentsUserStatus.AssessmentTemplateId,
                                    assessmentsUserStatus.ReportsTo,
                                    assessmentsUserStatus.UserRegionId,
                                    assessmentsUserStatus.StatusId,
                                    EnumHelper.GetEnumDescription((AssessmentState)int.Parse(assessmentsUserStatus.StatusId.ToString())),
                                    assessmentsUserStatus.EmployeeLevelId,
                                    assessmentsUserStatus.AssessmentScore.Name,
                                    assessmentsUserStatus.SiteCode,
                                    (assessmentUserScore == null ? 0 : assessmentUserScore.TotalScore),
                                     assessmentUserScore == null ? false : assessmentUserScore.ShowEmpLevel
                                )

                              )
                              .ToList();
            return result;
        }

        public async Task<IEnumerable<AssessmentUserStateModel>> GetByAssessmentId(int? templatetId)
        {
            Expression<Func<AssessmentUserStatus, bool>> whereClause = x => x.IsActive == true;

            if (templatetId != null)
                whereClause = x => x.AssessmentTemplateId == templatetId && x.IsActive == true;


            var assessmentsUserStatuses = await _dataContext.AssessmentUserStatus
           .Include(x => x.AssessmentScore)
           .AsNoTracking()
           .Where(whereClause)
           .ToListAsync();

            var assessmentUserStatusIds = assessmentsUserStatuses.Select(x => x.Id).ToList();
            var assessmentUserScores = await GetUserAnswerTotalScores(assessmentUserStatusIds);
            var results = GetAssessmentUserScoreModel(assessmentsUserStatuses, assessmentUserScores);

            return results.ToList();



        }

        public async Task<IEnumerable<AssessmentUserStateModel>> GetByManagerUserId(int? templatetId, int managerUserId)
        {
            Expression<Func<AssessmentUserStatus, bool>> whereClause = x => x.ReportsTo == managerUserId && x.IsActive == true;

            if (templatetId != null)
                whereClause = x => x.AssessmentTemplateId == templatetId && x.ReportsTo == managerUserId && x.IsActive == true;

            var assessmentsUserStatuses = await _dataContext.AssessmentUserStatus
             .Include(x => x.AssessmentScore)
             .AsNoTracking()
             .Where(whereClause)
             .ToListAsync();

            var assessmentUserStatusIds = assessmentsUserStatuses.Select(x => x.Id).ToList();
            var assessmentUserScores = await GetUserAnswerTotalScores(assessmentUserStatusIds);
            var results = GetAssessmentUserScoreModel(assessmentsUserStatuses, assessmentUserScores);

            return results.ToList();

        }

        public async Task<IEnumerable<AssessmentUserStateModel>> GetBySiteCode(int? templatetId, string siteCode)
        {
            Expression<Func<AssessmentUserStatus, bool>> whereClause = x => x.SiteCode == siteCode && x.IsActive == true;

            if (templatetId != null)
                whereClause = x => x.AssessmentTemplateId == templatetId && x.SiteCode == siteCode && x.IsActive == true;

            var assessmentsUserStatuses = await _dataContext.AssessmentUserStatus
            .Include(x => x.AssessmentScore)
            .AsNoTracking()
            .Where(whereClause)
            .ToListAsync();

            var assessmentUserStatusIds = assessmentsUserStatuses.Select(x => x.Id).ToList();
            var assessmentUserScores = await GetUserAnswerTotalScores(assessmentUserStatusIds);
            var results = GetAssessmentUserScoreModel(assessmentsUserStatuses, assessmentUserScores);

            return results.ToList();
        }

        public async Task<AssessmentUserStateModel> GetByAssessmentUserStatus(int assessmentUserStatusId)
        {

            var result = await _dataContext.AssessmentUserStatus
                .Include(x => x.AssessmentScore)
                .Include(x => x.AssessmentTemplate)
                .AsNoTracking()
                .Where(x => x.Id == assessmentUserStatusId)
                .FirstOrDefaultAsync();

            await UpdateFormChangedToFalse(result.Id);

            AssessmentUserStateModel response = null;
            if (result != null)
            {
                var assessmentAnswers = await _dataContext.AssessmentAnswers
                    .AsNoTracking()
                    .Where(x => x.AssessmentUserStatusId == result.Id)
                    .FirstOrDefaultAsync();

                int totalScore = (assessmentAnswers != null ? assessmentAnswers.TotalScore : 0);

                response = new AssessmentUserStateModel(
                        result.Id,
                        result.UserId,
                        result.AssessmentTemplateId,
                        result.ReportsTo,
                        result.UserRegionId,
                        result.StatusId,
                        EnumHelper.GetEnumDescription((AssessmentState)int.Parse(result.StatusId.ToString())),
                        result.EmployeeLevelId,
                        result.AssessmentScore.Name,
                        result.SiteCode,
                        result.formChanged,
                        result.LockedToUserId,
                        AssessmentHelper.IsAssessmentTemplateAvailable(result.AssessmentTemplate.StartDate, result.AssessmentTemplate.EndDate),
                        totalScore,
                        assessmentAnswers != null ? assessmentAnswers.ShowEmpLevel : false
                        );
            }

            return response;

        }

        public async Task<int> GetAssessmentTemplateScoreCriteriaByUserStateId(int id)
        {
            return await _dataContext
                .AssessmentUserStatus
                 .Include(x => x.AssessmentScore)
                .AsNoTracking()
                .Where(x => x.Id == id).Select(x => x.AssessmentTemplate.ScoreCriteriaId).FirstOrDefaultAsync();

        }


        public async Task<AssessmentUserStatusLockPinModel> GetAssessmentUserStatusLockPinById(int assessmentUserStatusId)
        {
            var result = await _dataContext.AssessmentUserStatus
                .Include(x => x.AssessmentScore)
                .AsNoTracking()
                .Where(x => x.Id == assessmentUserStatusId)
                .FirstOrDefaultAsync();

            if (result != null)
            {
                return new AssessmentUserStatusLockPinModel(
                        result.Id,
                        result.LockedToUserId,
                        result.Pin
                      );
            }

            return null;

        }

        public async Task<bool> GetAssessmentUserStatusIsLocked(int assessmentUserStatusId, int lockTwwId)
        {
            var result = await _dataContext.AssessmentUserStatus
                .Include(x => x.AssessmentScore)
                .AsNoTracking()
                .Where(x => x.Id == assessmentUserStatusId && x.LockedToUserId == lockTwwId).AnyAsync();

            return result;
        }

        //Endpoint to Identify Employee forms if locked to assisting manager.
        public async Task<IReadOnlyCollection<int>> GetAssessmentUserFormLockToAssistingManager(int twwid, int LockedToTwwIdId)
        {
            var assessmentUserStatus = await _dataContext.AssessmentUserStatus.AsNoTracking()
                .Where(x => x.UserId == twwid && x.LockedToUserId == LockedToTwwIdId)
                .Select(x => x.Id).ToListAsync();

            return assessmentUserStatus;
        }

        public async Task<IReadOnlyCollection<AssessmentUserFormModel>> GetAssessmentUserForm(string twwid, string actualManagerTwwid)
        {

            var assessmentUserStatus = await (from assessmentUsrStatus in _dataContext.AssessmentUserStatus.AsNoTracking()
                                              join assessmentTemplate in _dataContext.AssessmentTemplates.AsNoTracking() on assessmentUsrStatus.AssessmentTemplateId equals assessmentTemplate.Id
                                              join assessmentAnswer in _dataContext.AssessmentAnswers.AsNoTracking() on assessmentUsrStatus.Id equals assessmentAnswer.AssessmentUserStatusId into ans
                                              from assessmentAnswer in ans.DefaultIfEmpty()

                                              where assessmentUsrStatus.UserId == int.Parse(twwid) &&
                                                    assessmentUsrStatus.ReportsTo == int.Parse(actualManagerTwwid) &&
                                                    AssessmentHelper.IsAssessmentTemplateAvailable(assessmentTemplate.StartDate, assessmentTemplate.EndDate)

                                              select new
                                              {
                                                  assessmentUsrStatus.Id,
                                                  assessmentUsrStatus.AssessmentTemplateId,
                                                  assessmentTemplate.Title,
                                                  assessmentAnswer,
                                                  assessmentUsrStatus.StatusId,
                                                  assessmentUsrStatus.LockedToUserId,
                                                  assessmentTemplate.Year,
                                                  assessmentTemplate.TypeId
                                              }
                              ).ToListAsync();

            var assessmentUserFormModel = assessmentUserStatus.Select(x => new AssessmentUserFormModel(x.Id,
                                                        x.Title,
                                                        x.StatusId == (int)AssessmentState.Done ? x.assessmentAnswer.ApproverTwwId : 0,
                                                        (x.assessmentAnswer == null ? null : x.assessmentAnswer.DateTimeSubmitted),
                                                        x.StatusId,
                                                        EnumHelper.GetEnumDescription((AssessmentState)int.Parse(x.StatusId.ToString())),
                                                        x.LockedToUserId,
                                                        x.Year,
                                                        x.TypeId,
                                                        _dataContext.TemplatePermissions.Where(p => p.PermissionId == 4 && p.AssessmentTemplateId == x.AssessmentTemplateId).Count() > 0 ? true : false
                                                        )
                                  ).ToList();

            return assessmentUserFormModel.AsReadOnly();
        }

        public async Task<IReadOnlyCollection<AssessmentUserCompletedFormModel>> GetAssessmentUserCompletedForms(int userId)
        {

            var AssessmentUserCompletedForms = await (from assessmentUsrStatus in _dataContext.AssessmentUserStatus.Include(x => x.AssessmentTemplate).AsNoTracking()
                                                      join assessmentAnswer in _dataContext.AssessmentAnswers.AsNoTracking() on assessmentUsrStatus.Id equals assessmentAnswer.AssessmentUserStatusId into ans
                                                      from assessmentAnswer in ans.DefaultIfEmpty()
                                                      where assessmentUsrStatus.UserId == userId
                                                      select new
                                                      {
                                                          assessmentUsrStatusId = assessmentUsrStatus.Id,
                                                          title = assessmentUsrStatus.AssessmentTemplate.Title,
                                                          assessmentAnswer = assessmentAnswer,
                                                          year = assessmentUsrStatus.AssessmentTemplate.Year
                                                      })
                                             .Where(x => x.assessmentAnswer != null && x.assessmentAnswer.DateTimeSubmitted != null)
                                             .OrderByDescending(x => x.assessmentAnswer.DateTimeSubmitted)
                                             .ToListAsync();


            return AssessmentUserCompletedForms
                .Select(x => new AssessmentUserCompletedFormModel(x.assessmentUsrStatusId, x.title, x.assessmentAnswer.ApproverTwwId, x.assessmentAnswer.DateTimeSubmitted, x.assessmentAnswer.DateManagerApproved, x.year))
                .ToList();
        }

        public async Task<bool> UpdateAssessmentStatus(IReadOnlyCollection<AssessmentUserStateDTO> assessmentUserSateDTOs, IReadOnlyCollection<AssessmentUserStatusModifyByDTO> assessmentUserStatusModifyByDTOs)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
            var idList = assessmentUserSateDTOs.Select(x => x.Id).ToList();
            var assessmentUserStatuses = await GetAssessmentUserStatusByIds(idList);


            var assessmentUserStatusAnswer = await _dataContext.AssessmentAnswers
                .AsNoTracking()
                .Where(x => assessmentUserStatuses.Select(a => a.Id).Contains(x.AssessmentUserStatusId))
                .ToListAsync();

            var assessmentUserStatusAnswerClear = await _dataContext.AssessmentAnswers
                .Include(x => x.Answers)
            .AsNoTracking()
            .Where(x => assessmentUserStatusModifyByDTOs.Select(a => a.Id).Contains(x.AssessmentUserStatusId))
            .ToListAsync();

            var assessmentAnswers = new List<AssessmentAnswer>();
            var answers = new List<Answer>();

            if (assessmentUserStatuses != null)
            {
                foreach (var ass in assessmentUserStatuses)
                {
                    foreach (var dto in assessmentUserSateDTOs)
                    {
                        if (dto.StatusId == (int)AssessmentState.NotStarted)
                            ass.EmployeeLevelId = GetScoreCriteriaDefault(ass.AssessmentTemplateId);

                        ass.StatusId = dto.StatusId;
                        ass.ModifiedBy = dto.ModifiedBy;
                        ass.LockedToUserId = 0;
                        ass.Pin = string.Empty;

                        if (assessmentUserStatusAnswer != null && !assessmentUserStatusAnswerClear.Any())
                        {
                            foreach (var ans in assessmentUserStatusAnswer)
                            {
                                ans.DateTimeSubmitted = null;
                                assessmentAnswers.Add(ans);
                            }
                        }
                    }
                }

                if (assessmentUserStatusAnswerClear != null)
                {
                    foreach (var ans in assessmentUserStatusAnswerClear)
                    {
                        foreach (var dto in assessmentUserStatusModifyByDTOs)
                        {
                            if (dto.StatusId == (int)AssessmentState.NotStarted)
                                ans.ShowEmpLevel = false;

                            ans.ModifiedBy = dto.ModifiedBy;
                            ans.AnswersJson = string.Empty;
                            answers.AddRange(ans.Answers);
                            ans.DateModified = DateTime.UtcNow;
                            ans.DateEmployeeApproved = null;
                            ans.DateManagerApproved = null;
                            ans.DateTimeSubmitted = null;
                            ans.TotalScore = 0;
                            ans.ApproverTwwId = 0;
                            assessmentAnswers.Add(ans);
                        }
                    }
                }

                _dataContext.AssessmentUserStatus.UpdateRange(assessmentUserStatuses);
                _dataContext.AssessmentAnswers.UpdateRange(assessmentAnswers);
                _dataContext.Answers.RemoveRange(answers);
                await _dataContext.SaveChangesAsync();

                return true;
            }




            return false;
        }

        public async Task<bool> UpdateAssessmentStatus(AssessmentUserStateDTO assessmentUserSateDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            var assessmentUserStatus = await GetAssessmentUserStatusById(assessmentUserSateDTO.Id);

            if (assessmentUserStatus != null)
            {
                assessmentUserStatus.StatusId = assessmentUserSateDTO.StatusId;
                assessmentUserStatus.ModifiedBy = assessmentUserSateDTO.ModifiedBy;

                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateStatusAndEmployeeLevel(AssessmentStatusAndLevelDTO assessmentStatusAndLevelDTO, AssessmentUserStatusLockDTO assessmentUserStatusLockDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            Entities.AssessmentUserStatus assessmentUserStatus =
                await _dataContext.AssessmentUserStatus.AsNoTracking()
                     .FirstOrDefaultAsync(x => x.IsActive == true && x.Id == assessmentStatusAndLevelDTO.Id);

            if (assessmentUserStatus != null)
            {
                assessmentUserStatus.EmployeeLevelId = assessmentStatusAndLevelDTO.EmployeeLevelId;
                assessmentUserStatus.StatusId = assessmentStatusAndLevelDTO.StatusId;
                assessmentUserStatus.ModifiedBy = assessmentStatusAndLevelDTO.ModifiedBy;

                assessmentUserStatus.LockedToUserId = assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId;
                assessmentUserStatus.Pin = assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin;

                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateStatusAndEmployeeLevel(AssessmentStatusAndLevelDTO assessmentStatusAndLevelDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            Entities.AssessmentUserStatus assessmentUserStatus =
                await _dataContext.AssessmentUserStatus.AsNoTracking()
                     .FirstOrDefaultAsync(x => x.IsActive == true && x.Id == assessmentStatusAndLevelDTO.Id);

            if (assessmentUserStatus != null)
            {
                assessmentUserStatus.EmployeeLevelId = assessmentStatusAndLevelDTO.EmployeeLevelId;
                assessmentUserStatus.StatusId = assessmentStatusAndLevelDTO.StatusId;
                assessmentUserStatus.ModifiedBy = assessmentStatusAndLevelDTO.ModifiedBy;

                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> IsExists(int id)
        {
            return await _dataContext.AssessmentUserStatus.FindAsync(id) != null ? true : false;
        }

        public async Task<bool> IsAssessmentAvailable(int assessmentUserStatusId)
        {
            var result = await _dataContext.AssessmentUserStatus
                .Include(x => x.AssessmentTemplate)
                .AsNoTracking()
                .Where(x => x.Id == assessmentUserStatusId && AssessmentHelper.IsAssessmentTemplateAvailable(x.AssessmentTemplate.StartDate, x.AssessmentTemplate.EndDate) && x.IsActive == true)
                .AnyAsync();
            return result;

        }

        public async Task<IEnumerable<AssessmentUserStateModel>> GetAssessmentUserStatusByTemplateAndUser(IReadOnlyCollection<TemplateUserDTO> templateUserDTOs)
        {

            var assessmentsUserStatuses = await (from assessmentUserStatus in _dataContext.AssessmentUserStatus.AsNoTracking().Include(x => x.AssessmentScore)
                                                 join dto in templateUserDTOs on assessmentUserStatus.AssessmentTemplateId equals dto.TemplateId
                                                 where assessmentUserStatus.UserId == dto.UserId
                                                 select assessmentUserStatus
                                                 ).ToListAsync();

            var assessmentUserStatusIds = assessmentsUserStatuses.Select(x => x.Id).ToList();
            var assessmentUserScores = await GetUserAnswerTotalScores(assessmentUserStatusIds);
            var results = GetAssessmentUserScoreModel(assessmentsUserStatuses, assessmentUserScores);

            return results;

        }

        public async Task<bool> UpdateAssessmentStatusTemplate(AssessmentUserStatusTemplateDTO assessmentUserSateDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
            Entities.AssessmentUserStatus assessmentUserStatus =
                await _dataContext.AssessmentUserStatus.AsNoTracking()
                     .FirstOrDefaultAsync(x => x.IsActive == true && x.Id == assessmentUserSateDTO.AssessmentUserStatusId);

            if (assessmentUserStatus != null)
            {
                assessmentUserStatus.AssessmentTemplateId = assessmentUserSateDTO.TemplateId;
                assessmentUserStatus.ModifiedBy = assessmentUserSateDTO.ModifyBy;

                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<int> GetAssessmentTemplateIdById(int assessmentUserStatusId)
        {
            int assessmentCode =
            await _dataContext.AssessmentUserStatus.AsNoTracking()
                    .Where(x => x.Id == assessmentUserStatusId && x.IsActive == true)
                    .Select(x => x.AssessmentTemplateId)
                    .FirstOrDefaultAsync();

            return assessmentCode;
        }

        public async Task<AssessmentUserStatusStateModel> GetAssessmentUserStatusState(int assessmentUserStatusId)
        {
            var result = await _dataContext.AssessmentUserStatus
                .Include(x => x.AssessmentScore)
                .AsNoTracking()
                .Where(x => x.Id == assessmentUserStatusId)
                .FirstOrDefaultAsync();

            if (result != null)
            {
                return new AssessmentUserStatusStateModel(
                            result.Id,
                            result.StatusId,
                            EnumHelper.GetEnumDescription((AssessmentState)int.Parse(result.StatusId.ToString())),
                            result.EmployeeLevelId,
                            result.AssessmentScore.Name
                      );
            }
            else
            {
                return null;
            }
        }

        public async Task<IReadOnlyCollection<AssessmentUserStatusStateModel>> GetAssessmentUserStatusStateByIds(IReadOnlyCollection<int> assessmentUserStatusIds)
        {
            return await _dataContext.AssessmentUserStatus
                 .Include(x => x.AssessmentScore)
                 .AsNoTracking()
                 .Where(x => assessmentUserStatusIds.Contains(x.Id))
                 .Select(x => new AssessmentUserStatusStateModel(
                         x.Id,
                         x.StatusId,
                         EnumHelper.GetEnumDescription((AssessmentState)int.Parse(x.StatusId.ToString())),
                         x.EmployeeLevelId,
                         x.AssessmentScore.Name
                     ))
                 .ToListAsync();
        }

        public async Task<IEnumerable<AssessmentUserStateModel>> GeAssessmentExceptUserInList(int[] userIds, int? permissionId, string siteCode, int? formTypeId)
        {
            if (formTypeId == null)
            {
                formTypeId = await _dataContext.AssessmentTemplates
                .Where(x => x.IsActive == true && AssessmentHelper.IsAssessmentTemplateAvailable(x.StartDate, x.EndDate))
                .OrderByDescending(x => x.Year)
                .ThenByDescending(x => x.StartDate)
                .Select(x => x.TypeId)
                .FirstOrDefaultAsync();
            }

            var assessmentSummary = await _dataContext.AssessmentUserStatus
            .Include(x => x.AssessmentScore)
            .Include(x => x.AssessmentTemplate)
                .ThenInclude(x => x.Assessment)
            .AsNoTracking()
            .Where(x => userIds.Contains(x.UserId) == false
                && x.IsActive == true
                && (permissionId == 3 ? x.SiteCode == siteCode : true)
                && (x.AssessmentTemplate.TypeId == formTypeId))
            .ToListAsync();


            var assessmentUserStatusIds = assessmentSummary.Select(x => x.Id).ToList();
            var assessmentUserScores = await GetUserAnswerTotalScores(assessmentUserStatusIds);

            var results = (from assessmentsUserStatus in assessmentSummary
                           join assessmentUserScore in assessmentUserScores
                                on assessmentsUserStatus.Id equals assessmentUserScore.AssessmentUserStatusId
                                   into userScores
                           from assessmentUserScore in userScores.DefaultIfEmpty()
                           select new AssessmentUserStateModel(
                              assessmentsUserStatus.Id,
                              assessmentsUserStatus.UserId,
                              assessmentsUserStatus.AssessmentTemplateId,
                              assessmentsUserStatus.ReportsTo,
                              assessmentsUserStatus.UserRegionId,
                              assessmentsUserStatus.StatusId,
                              EnumHelper.GetEnumDescription((AssessmentState)int.Parse(assessmentsUserStatus.StatusId.ToString())),
                              assessmentsUserStatus.EmployeeLevelId,
                              assessmentsUserStatus.AssessmentScore.Name,
                              assessmentsUserStatus.SiteCode,
                              assessmentsUserStatus.formChanged,
                              assessmentsUserStatus.LockedToUserId,
                              !AssessmentHelper.IsAssessmentTemplateAvailable(assessmentsUserStatus.AssessmentTemplate.StartDate, assessmentsUserStatus.AssessmentTemplate.EndDate),
                              (assessmentUserScore == null ? 0 : assessmentUserScore.TotalScore),
                              assessmentUserScore == null ? false : assessmentUserScore.ShowEmpLevel
                              ));

            return results;
        }

        public async Task<IReadOnlyCollection<UserFormAndStatusModel>> GetEmployeeFormType(string[] twwids)
        {

            var sortedResults = await _dataContext.AssessmentUserStatus
            .AsNoTracking()
            .Include(x => x.AssessmentTemplate)
                .ThenInclude(x => x.AssessmentFormType)
            .Include(x => x.AssessmentTemplate)
                .ThenInclude(x => x.TemplatePermissions)
            .Where(x => twwids.Contains(x.UserId.ToString()) && (AssessmentHelper.IsAssessmentTemplateAvailable(x.AssessmentTemplate.StartDate, x.AssessmentTemplate.EndDate)) && (x.AssessmentTemplate.IsActive))
            .OrderByDescending(x => x.AssessmentTemplate.Year)
            .ThenByDescending(x => x.AssessmentTemplate.StartDate)
                .ThenByDescending(x => x.AssessmentTemplate.Version)
            .Distinct()
            .ToListAsync();


            var listOfUserFormAndStatusModel = new List<UserFormAndStatusModel>();

            foreach (var result in sortedResults)
            {
                listOfUserFormAndStatusModel.Add(new UserFormAndStatusModel(
                    result.UserId.ToString(),
                    result.StatusId,
                    result.Id,
                    result.AssessmentTemplate.TemplatePermissions.Where(p => p.PermissionId == 4).Count() > 0 ? true : false,
                    result.LockedToUserId,
                    result.ReportsTo.ToString(),
                    _dataContext.AssessmentUserStatus
                        .AsNoTracking()
                            .Include(x => x.AssessmentTemplate)
                                 .ThenInclude(x => x.TemplatePermissions)
                        .Where(x => x.UserId == result.UserId && x.IsActive == true
                            && x.StatusId != (int)AssessmentState.Done
                            && AssessmentHelper.IsAssessmentTemplateAvailable(x.AssessmentTemplate.StartDate, x.AssessmentTemplate.EndDate))
                        .Select(x => new UserFormAndStatusModel.AssessmentTemplateFormModel
                        {
                            AssessmentUserStatusId = x.Id,
                            TemplateTitle = x.AssessmentTemplate.Title,
                            TemplateYear = x.AssessmentTemplate.Year,
                            IsManagerForm = x.AssessmentTemplate.TemplatePermissions.Where(p => p.PermissionId == 4).Count() > 0 ? true : false,
                        })
                    .ToArray()
                ));
            }

            return listOfUserFormAndStatusModel.AsReadOnly();
        }

        public async Task<int> UpdateForm(int assessmentId, int currentUserId, int latestTemplateId)
        {

            var updateDetail = new AssessmentUserStatusTemplateDTO
            {

                AssessmentUserStatusId = assessmentId,
                TemplateId = latestTemplateId,
                ModifyBy = currentUserId
            };

            bool isUpdated = await UpdateAssessmentStatusTemplateAndResetStatus(updateDetail);

            if (isUpdated)
                return assessmentId;

            return -1;
        }

        public int GetLatestFormOfPermission(int permissionId)
        {
            var latestAssessmentOfPermission = _dataContext.TemplatePermissions
                    .AsNoTracking()
                    .Include(x => x.AssessmentTemplate)
                    .Where(x => x.PermissionId == permissionId
                        && x.AssessmentTemplate.IsActive == true
                        && AssessmentHelper.IsAssessmentTemplateAvailable(x.AssessmentTemplate.StartDate, x.AssessmentTemplate.EndDate))
                    .OrderByDescending(x => x.AssessmentTemplate.Year)
                        .ThenByDescending(x => x.AssessmentTemplate.StartDate)
                            .ThenByDescending(x => x.AssessmentTemplate.Version)
                    .ToList();

            return latestAssessmentOfPermission.Select(x => x.AssessmentTemplate.Id).FirstOrDefault();

        }

        public AssessmentTemplateModel GetLatestFormOfPermission(int permissionId, int year, int formTypeId)
        {
            var latestAssessmentOfPermission = _dataContext.TemplatePermissions
                    .AsNoTracking()
                    .Include(x => x.AssessmentTemplate)
                    .Where(x => x.PermissionId == permissionId
                        && x.AssessmentTemplate.IsActive == true
                        && AssessmentHelper.IsAssessmentTemplateAvailable(x.AssessmentTemplate.StartDate, x.AssessmentTemplate.EndDate)
                        && x.AssessmentTemplate.Year == year
                        && x.AssessmentTemplate.TypeId == formTypeId
                        )
                    .OrderByDescending(x => x.AssessmentTemplate.Year)
                        .ThenByDescending(x => x.AssessmentTemplate.StartDate)
                            .ThenByDescending(x => x.AssessmentTemplate.Version)
                    .ToList();

            return latestAssessmentOfPermission.Select(x => new AssessmentTemplateModel(
                x.AssessmentTemplate.Id,
                x.AssessmentTemplate.Year,
                x.AssessmentTemplate.Title,
                x.AssessmentTemplate.Version,
                x.AssessmentTemplate.IsActive,
                (EScoreCriteria)x.AssessmentTemplate.ScoreCriteriaId,
                x.AssessmentTemplate.TypeId,
                x.AssessmentTemplate.isStash
                )).FirstOrDefault();

        }

        public async Task<IReadOnlyCollection<AssessmentUserStateModel>> GetEmployeeAssessmentDetail(int[] twwids, int? formTypeId)
        {
            if (formTypeId == null)
            {
                formTypeId = await _dataContext.AssessmentTemplates
                .Where(x => x.IsActive == true && AssessmentHelper.IsAssessmentTemplateAvailable(x.StartDate, x.EndDate))
                .OrderByDescending(x => x.Year)
                .ThenByDescending(x => x.StartDate)
                .Select(x => x.TypeId)
                .FirstOrDefaultAsync();
            }

            var summary = await _dataContext.AssessmentUserStatus
                .AsNoTracking()
                .Include(x => x.AssessmentScore)
                .Include(x => x.AssessmentTemplate)
                    .ThenInclude(x => x.Assessment)
                .Where(x =>
                    twwids.Contains(x.UserId)
                    && x.IsActive == true
                    && (x.AssessmentTemplate.TypeId == formTypeId))
                .ToListAsync();

            var assessmentUserStatusIds = summary.Select(x => x.Id).ToList();
            var assessmentUserScores = await GetUserAnswerTotalScores(assessmentUserStatusIds);

            var results = (from assessmentsUserStatus in summary
                           join assessmentUserScore in assessmentUserScores
                                on assessmentsUserStatus.Id equals assessmentUserScore.AssessmentUserStatusId
                                   into userScores
                           from assessmentUserScore in userScores.DefaultIfEmpty()
                           select new AssessmentUserStateModel(
                                assessmentsUserStatus.Id,
                                assessmentsUserStatus.UserId,
                                assessmentsUserStatus.AssessmentTemplateId,
                                assessmentsUserStatus.ReportsTo,
                                assessmentsUserStatus.UserRegionId,
                                assessmentsUserStatus.StatusId,
                                EnumHelper.GetEnumDescription((AssessmentState)int.Parse(assessmentsUserStatus.StatusId.ToString())),
                                assessmentsUserStatus.EmployeeLevelId,
                                assessmentsUserStatus.AssessmentScore.Name,
                                assessmentsUserStatus.SiteCode,
                                assessmentsUserStatus.formChanged,
                                assessmentsUserStatus.LockedToUserId,
                                AssessmentHelper.IsAssessmentTemplateAvailable(assessmentsUserStatus.AssessmentTemplate.StartDate, assessmentsUserStatus.AssessmentTemplate.EndDate),
                                (assessmentUserScore == null ? 0 : assessmentUserScore.TotalScore),
                                assessmentUserScore == null ? false : assessmentUserScore.ShowEmpLevel))
                                .ToList();



            return results;
        }

        public async Task<IReadOnlyCollection<UserCommentAvailabilityModel>> GetUserCommentAvailability(int assessmentUserStatusId)
        {
            bool available = true;
            return await _dataContext.AssessmentUserComments
                .AsNoTracking()
                .Where(x => x.AssessmentUserStatusId == assessmentUserStatusId)
                .Select(x => new UserCommentAvailabilityModel(available, x.CategoryCode))
                .Distinct()
                .ToListAsync();

        }

        public async Task<IReadOnlyCollection<UserCommentsModel>> GetAssessmentUserComments(AssessmentUserStatusCategoryDTO assessmentUserStatusCategoryDTO)
        {

            return await _dataContext.AssessmentUserComments
                   .AsNoTracking()
                   .Where(x => x.AssessmentUserStatusId == assessmentUserStatusCategoryDTO.AssessmentUserStatusId && x.CategoryCode == assessmentUserStatusCategoryDTO.CategoryCode)
                   .Select(x => new UserCommentsModel(x.Id, x.TwwId, x.ParentId, x.IsEdited, x.CreatedDateTime, x.ModifiedDateTime, x.Comments))
                   .ToListAsync();
        }

        private int GetScoreCriteriaDefault(int assessmentTemplateId)
        {
            var scoreCriteriaId = _dataContext.AssessmentTemplates
                .AsNoTracking()
                .Where(x => x.Id == assessmentTemplateId)
                .Select(x => x.ScoreCriteriaId)
                .FirstOrDefault();

            var defaultScore = _dataContext.AssessmentScore
                .AsNoTracking()
                .Where(x => x.ScoreCriteriaId == scoreCriteriaId)
                .OrderBy(x => x.Min)
                .Select(x => x.Id)
                .FirstOrDefault();

            return defaultScore;

        }

        public async Task<bool> UpdateAssessmentStatusTemplateAndResetStatus(AssessmentUserStatusTemplateDTO assessmentUserSateDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
            Entities.AssessmentUserStatus assessmentUserStatus =
                await _dataContext.AssessmentUserStatus
                    .AsNoTracking()
                    .Include(x => x.AssessmentTemplate)
                    .FirstOrDefaultAsync(x =>
                        x.IsActive == true
                        && x.Id == assessmentUserSateDTO.AssessmentUserStatusId
                     );

            if (assessmentUserStatus != null)
            {
                assessmentUserStatus.AssessmentTemplateId = assessmentUserSateDTO.TemplateId;
                assessmentUserStatus.ModifiedBy = assessmentUserSateDTO.ModifyBy;
                assessmentUserStatus.formChanged = assessmentUserStatus.StatusId == 1 ? true : false;
                assessmentUserStatus.StatusId = 0;
                assessmentUserStatus.EmployeeLevelId = GetScoreCriteriaDefault(assessmentUserSateDTO.TemplateId);

                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                await ClearAnswer(assessmentUserStatus.Id);

                return true;
            }

            return false;
        }

        public async Task<bool> ClearAnswer(int userAssessmentStatusId)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
            Entities.AssessmentAnswer assessmentAnswer =
                await _dataContext.AssessmentAnswers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.AssessmentUserStatusId == userAssessmentStatusId);

            if (assessmentAnswer != null)
            {
                IReadOnlyCollection<Answer> answers = await _dataContext.Answers.AsNoTracking()
                    .Where(x => x.AssessmentAnswerId == assessmentAnswer.Id)
                    .ToListAsync();


                assessmentAnswer.AnswersJson = "";
                assessmentAnswer.ShowEmpLevel = false;
                assessmentAnswer.TotalScore = 0;
                _dataContext.Entry(assessmentAnswer).State = EntityState.Modified;
                _dataContext.RemoveRange(answers);
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;

        }

        public async Task<bool> UpdateAssessmentUserLockPin(AssessmentUserStatusLockDTO assessmentUserStatusLockDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            var assessmentUserStatus = await GetAssessmentUserStatusById(assessmentUserStatusLockDTO.AssessmentUserStatusId);

            if (assessmentUserStatus != null)
            {
                assessmentUserStatus.LockedToUserId = assessmentUserStatusLockDTO.LockPinDTO.LockTwwIdDTO.TwwId;
                assessmentUserStatus.Pin = assessmentUserStatusLockDTO.LockPinDTO.PinDTO.Pin;

                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateFormChangedToFalse(int assessmentUserStatusId)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            Entities.AssessmentUserStatus assessmentUserStatus =
                await _dataContext.AssessmentUserStatus.AsNoTracking()
                     .FirstOrDefaultAsync(x => x.IsActive == true && x.Id == assessmentUserStatusId && x.formChanged != false);

            if (assessmentUserStatus != null)
            {

                assessmentUserStatus.formChanged = false;
                _dataContext.Entry(assessmentUserStatus).State = EntityState.Modified;
                await _dataContext.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> ResetLockAndPinByAssessmentUserStatusIds(IReadOnlyCollection<int> assessmentUserStatusIds)
        {

            List<AssessmentUserStatus> assessmentUserStatuses =
                await _dataContext.AssessmentUserStatus
                        .Where(x => x.IsActive == true && assessmentUserStatusIds.Contains(x.Id))
                        .ToListAsync();

            if (assessmentUserStatuses != null)
            {
                foreach (AssessmentUserStatus assessment in assessmentUserStatuses)
                {
                    assessment.Pin = null;
                    assessment.LockedToUserId = 0;
                }

                _dataContext.AssessmentUserStatus.UpdateRange(assessmentUserStatuses);
                await _dataContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<AssessmentUserCommentModel> InsertAssessmentUserCommentModel(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO)
        {

            var assessmentUserComment = new AssessmentUserComment()
            {
                AssessmentUserStatusId = assessmentUserStatusCommentDTO.AssessmentUserStatusId,
                CategoryCode = assessmentUserStatusCommentDTO.CategoryCode,
                IsEdited = assessmentUserStatusCommentDTO.IsEdited,
                ParentId = assessmentUserStatusCommentDTO.ParentId,
                Comments = assessmentUserStatusCommentDTO.Comments,
                TwwId = assessmentUserStatusCommentDTO.TwwId,
                CreatedDateTime = assessmentUserStatusCommentDTO.CreatedDateTime,
                ModifiedDateTime = assessmentUserStatusCommentDTO.ModifiedDateTime

            };

            _dataContext.Add(assessmentUserComment);
            await _dataContext.SaveChangesAsync();

            var assessmentUserCommentModel = new AssessmentUserCommentModel(assessmentUserComment.Id, assessmentUserComment.ParentId, assessmentUserComment.IsEdited, assessmentUserComment.ModifiedDateTime);

            return assessmentUserCommentModel;

        }

        public async Task<IReadOnlyCollection<UserCommentDetailModel>> GeUserCommentDetails(int id)
        {
            var userComments = await _dataContext.AssessmentUserComments
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Select(x => new UserCommentDetailModel(x.Id, x.CategoryCode, x.AssessmentUserStatusId, x.TwwId, x.ParentId, x.IsEdited, x.CreatedDateTime, x.ModifiedDateTime, x.Comments))
                .ToListAsync();

            return userComments;
        }

        public async Task<bool> GetUserCommentsExistence(int id)
        {
            var userCommentsExist = await _dataContext.AssessmentUserComments
             .AsNoTracking()
             .Where(x => x.Id == id)
             .AnyAsync();

            return userCommentsExist;
        }

        public async Task<bool> GetUserChildCommentsExistence(int id)
        {
            var userCommentsExist = await _dataContext.AssessmentUserComments
              .AsNoTracking()
              .Where(x => x.ParentId == id)
              .AnyAsync();

            return userCommentsExist;
        }

        public async Task<int> Delete(int id) => await DeleteData(id);

        public override async Task<int> DeleteData(int id)
        {
            var assessmentUserComment = new AssessmentUserComment()
            {
                Id = id
            };

            _dataContext.Remove(assessmentUserComment);
            return await _dataContext.SaveChangesAsync();
        }

        public override async Task<AssessmentUserCommentModel> UpdateData(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;

            var userComment = await GetUserComment(assessmentUserStatusCommentDTO.Id);

            userComment.IsEdited = assessmentUserStatusCommentDTO.IsEdited;
            userComment.ModifiedDateTime = assessmentUserStatusCommentDTO.ModifiedDateTime;
            userComment.Comments = assessmentUserStatusCommentDTO.Comments;

            _dataContext.Entry(userComment).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();

            var assessmentUserCommentModel = new AssessmentUserCommentModel(userComment.Id, userComment.ParentId, userComment.IsEdited, userComment.ModifiedDateTime);

            return assessmentUserCommentModel;

        }

        public async Task<AssessmentLinkFormDetailModel> InsertAssessmentLinkForm(AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            return await InsertData1(assessmentLinkFormDTO);
        }

        public override async Task<AssessmentLinkFormDetailModel> InsertData1(AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            var assessmentLinkForm = new AssessmentLinkForm()
            {
                AssessmentUserstatusId = assessmentLinkFormDTO.AssessmentUserStatusId,
                LinkedAssessmentUserstatusId = assessmentLinkFormDTO.LinkedAssessmentUserStatusId,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = assessmentLinkFormDTO.CreatedByTwwId
            };

            _dataContext.Add(assessmentLinkForm);
            await _dataContext.SaveChangesAsync();

            var getLinkfromInfo = await GetAssessmentFromLinkFormDetail(assessmentLinkForm.AssessmentUserstatusId);

            return getLinkfromInfo;
        }

        public async Task<int> DeleteAssessmentLinkFormById(int id)
        {
            return await DeleteData1(id);
        }

        public async Task<int> DeleteAssessmentLinkForm(int assessmentUserStatusIds)
        {
            return await DeleteDatabyAssessmentUserStatusId(assessmentUserStatusIds);
        }

        public override async Task<int> DeleteData1(int id)
        {
            var assessmentLinkForm = new AssessmentLinkForm()
            {
                Id = id
            };

            _dataContext.Remove(assessmentLinkForm);
            return await _dataContext.SaveChangesAsync();
        }

        public override async Task<int> DeleteDatabyAssessmentUserStatusId(int assessmentUserStatusIds)
        {
            var assessmentLinkForm = _dataContext.AssessmentLinkForms
                .AsNoTracking()
                .Where(w => w.AssessmentUserstatusId == assessmentUserStatusIds)
                .FirstOrDefault();

            _dataContext.Remove(assessmentLinkForm);
            return await _dataContext.SaveChangesAsync();
        }

        public async Task<AssessmentUserCommentModel> Update(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO)
        {
            return await UpdateData(assessmentUserStatusCommentDTO);
        }

        public async Task<AssessmentLinkFormDetailModel> GetAssessmentFromLinkFormDetail(int assessmentUserStatusId)
        {

            var assessmentLinkForms = await _dataContext.AssessmentLinkForms
                                                 .AsNoTracking()
                                                 .Where(x => x.AssessmentUserstatusId == assessmentUserStatusId)
                                                 .ToListAsync();

            var getssessmentUserStatusId = assessmentLinkForms.Select(x => x.AssessmentUserstatusId).Distinct();
            var getLinkedAssessmentUserstatusId = assessmentLinkForms.Select(x => x.LinkedAssessmentUserstatusId).Distinct();
            var allAssessmentUserstatusId = (getssessmentUserStatusId.Union(getLinkedAssessmentUserstatusId)).Distinct();

            var getTamplateinfo = await _dataContext.AssessmentUserStatus.Include(x => x.AssessmentTemplate)
                                                    .AsNoTracking()
                                                    .Where(x => allAssessmentUserstatusId.Contains(x.Id))
                                                    .ToListAsync();



            var AssessmentUserCompletedForms = (from assessmentForm in assessmentLinkForms
                                                from templateInfo in getTamplateinfo
                                                          .Where(x => x.Id == assessmentForm.AssessmentUserstatusId)
                                                          .DefaultIfEmpty()
                                                from templateLinkedInfo in getTamplateinfo
                                                           .Where(x => x.Id == assessmentForm.LinkedAssessmentUserstatusId)
                                                           .DefaultIfEmpty()

                                                where assessmentForm.AssessmentUserstatusId == assessmentUserStatusId
                                                select new AssessmentLinkFormDetailModel(
                                                          assessmentForm.Id,
                                                          assessmentForm.AssessmentUserstatusId,
                                                          templateInfo.AssessmentTemplate.Title,
                                                          templateInfo.AssessmentTemplate.Year,
                                                          assessmentForm.LinkedAssessmentUserstatusId,
                                                          templateLinkedInfo.AssessmentTemplate.Title,
                                                          templateLinkedInfo.AssessmentTemplate.Year,
                                                          assessmentForm.CreatedBy,
                                                          assessmentForm.CreatedDate))
                                                          .FirstOrDefault();


            return AssessmentUserCompletedForms;
        }

        public async Task<AssessmentLinkFormDetailModel> UpdateAssessmentLinkForm(int id, AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            _dataContext.ChangeTracker.AutoDetectChangesEnabled = false;
            var assessmentLinkForm = await GetAssessmentLinkForm(id);
            assessmentLinkForm.AssessmentUserstatusId = assessmentLinkFormDTO.AssessmentUserStatusId;
            assessmentLinkForm.LinkedAssessmentUserstatusId = assessmentLinkFormDTO.LinkedAssessmentUserStatusId;
            assessmentLinkForm.CreatedBy = assessmentLinkFormDTO.CreatedByTwwId;

            _dataContext.Entry(assessmentLinkForm).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();

            var getLinkfromInfo = await GetAssessmentFromLinkFormDetail(assessmentLinkForm.AssessmentUserstatusId);

            return getLinkfromInfo;
        }


    }
}
