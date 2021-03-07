using AssessmentPersistence.Entities;
using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentUserStatusPersistence
    {
        Task<IEnumerable<AssessmentUserStateModel>> GetByAssessmentId(int? templatetId);
        Task<IEnumerable<AssessmentUserStateModel>> GetBySiteCode(int? templatetId, string siteCode);
        Task<IEnumerable<AssessmentUserStateModel>> GetByManagerUserId(int? templatetId, int managerUserId);
        Task<AssessmentUserStateModel> GetByAssessmentUserStatus(int assessmentUserStatusId);
        Task<AssessmentUserStatusLockPinModel> GetAssessmentUserStatusLockPinById(int assessmentUserStatusId);
        Task<AssessmentUserStatusStateModel> GetAssessmentUserStatusState(int assessmentUserStatusId);
        Task<IReadOnlyCollection<AssessmentUserStatusStateModel>> GetAssessmentUserStatusStateByIds(IReadOnlyCollection<int> assessmentUserStatusIds);
        Task<int> GetAssessmentTemplateIdById(int assessmentUserStatusId);
        Task<IEnumerable<AssessmentUserStateModel>> GeAssessmentExceptUserInList(int[] userIds, int? permissionId, string siteCode, int? formTypeId);
        Task<IReadOnlyCollection<UserFormAndStatusModel>> GetEmployeeFormType(string[] twwids);
        Task<IReadOnlyCollection<AssessmentUserCompletedFormModel>> GetAssessmentUserCompletedForms(int userId);
        Task<IReadOnlyCollection<int>> GetAssessmentUserFormLockToAssistingManager(int twwid, int LockedToTwwIdId);
        Task<IReadOnlyCollection<AssessmentUserFormModel>> GetAssessmentUserForm(string twwid, string actualManagerTwwid);
        int GetLatestFormOfPermission(int permissionId);
        AssessmentTemplateModel GetLatestFormOfPermission(int permissionId, int year, int formTypeId);
        Task<IReadOnlyCollection<AssessmentUserStateModel>> GetEmployeeAssessmentDetail(int[] twwids, int? formTypeId);
        Task<IReadOnlyCollection<UserCommentAvailabilityModel>> GetUserCommentAvailability(int assessmentUserStatusId);
        Task<bool> GetUserCommentsExistence(int id);
        Task<bool> GetUserChildCommentsExistence(int id);
        Task<IReadOnlyCollection<UserCommentDetailModel>> GeUserCommentDetails(int id);
        Task<IReadOnlyCollection<UserCommentsModel>> GetAssessmentUserComments(AssessmentUserStatusCategoryDTO assessmentUserStatusCategoryDTO);
        Task<bool> GetAssessmentLinkFormIsExist(int assessmentUserStatusId);
        Task<AssessmentLinkFormDetailModel> GetAssessmentFromLinkFormDetail(int assessmentUserStatusId);
        Task<bool> GetAssessmentUserStatusIsLocked(int assessmentUserStatusId, int lockTwwId);
        Task<int> GetAssessmentTemplateScoreCriteriaByUserStateId(int id);
        Task<bool> UpdateAssessmentUserLockPin(AssessmentUserStatusLockDTO assessmentUserStatusLockDTO);
        Task<bool> UpdateAssessmentStatus(AssessmentUserStateDTO assessmentUserSateDTO);
        Task<bool> UpdateAssessmentStatus(IReadOnlyCollection<AssessmentUserStateDTO> assessmentUserSateDTOs, IReadOnlyCollection<AssessmentUserStatusModifyByDTO> assessmentUserStatusModifyByDTOs);
        Task<bool> UpdateStatusAndEmployeeLevel(AssessmentStatusAndLevelDTO assessmentStatusAndLevelDTO, AssessmentUserStatusLockDTO assessmentUserStatusLockDTO);
        Task<bool> UpdateStatusAndEmployeeLevel(AssessmentStatusAndLevelDTO assessmentStatusAndLevelDTO);
        Task<AssessmentUserCommentModel> InsertAssessmentUserCommentModel(AssessmentUserStatusCommentDTO assessmentUserStatusCommentDTO);      
        Task<bool> IsExists(int id);
        Task<bool> IsAssessmentAvailable(int assessmentUserStatusId);
        Task<IEnumerable<AssessmentUserStateModel>> GetAssessmentUserStatusByTemplateAndUser(IReadOnlyCollection<TemplateUserDTO> templateUserDTOs);
        Task<bool> UpdateAssessmentStatusTemplate(AssessmentUserStatusTemplateDTO assessmentUserSateDTO);
        Task<int> UpdateForm(int assessmentId, int currentUserId, int latestTemplateId);
        Task<bool> UpdateFormChangedToFalse(int assessmentUserStatusId);
        Task<bool> ResetLockAndPinByAssessmentUserStatusIds(IReadOnlyCollection<int> assessmentUserStatusIds);
        Task<AssessmentLinkFormDetailModel> InsertAssessmentLinkForm(AssessmentLinkFormDTO assessmentLinkFormDTO);
        Task<int> DeleteAssessmentLinkForm(int assessmentUserStatusIds);
        Task<int> DeleteAssessmentLinkFormById(int id);
        Task<AssessmentLinkFormDetailModel> UpdateAssessmentLinkForm(int id, AssessmentLinkFormDTO assessmentLinkFormDTO);
    }
}
