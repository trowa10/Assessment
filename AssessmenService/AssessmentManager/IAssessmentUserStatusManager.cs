using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentUserStatusManager
    {
        Task<IEnumerable<AssessmentUserStateModel>> GetAll(int roleid, int? assessmentid, string siteCode, int userid);
        Task<AssessmentUserStateModel> GetByAssessmentUserStatusId(int id);
        Task<ResponseModel> GenerateAssessmentUserStatusByAction(AssessmentUserStatusActionLockDTO assessmentUserStatusActionLockDTO);
        Task<IReadOnlyCollection<int>> GetAssessmentUserFormLockToAssistingManager(int twwid, int LockedToTwwIdId);
        Task<IReadOnlyCollection<AssessmentUserFormModel>> GetAssessmentUserForm(UserManagerDTO userManagerDTO);
        Task<IReadOnlyCollection<AssessmentUserCompletedFormModel>> GetAssessmentUserCompletedForms(int userId);
        Task<IReadOnlyCollection<AssessmentUserCommentsModel>> GetAssessmentUserComments(AssessmentUserStatusCategoryDTO assessmentUserStatusCategoryDTO);        
        Task<bool> UpdateAssessmentStatus(AssessmentUserStateDTO assessmentUserSateDTO);
        Task<bool> UpdateAssessmentUserStateClearAnswerIfNotDone(IReadOnlyCollection<AssessmentUserStateDTO> assessmentUserSateDTOs);        
        Task<bool> BulkInsertOrUpdateAssessmentUserStatus(IReadOnlyCollection<AssessmentUserStatusPermissionDTO> assessmentUserStatusDTO);
        Task<ResponseModel> InsertAssessmentUserComment(AssessmentUserCommentDTO assessmentUserCommentDTO);
        Task<ResponseModel> UpdateComment(AssessmentUserCommentUpdateDTO assessmentUserCommentUpdateDTO);
        Task<bool> UpdateAssessmentStatusTemplate(AssessmentUserStatusTemplateDTO assessmentUserSateDTO);
        Task<AssessmentUserStatusStateModel> GetAssessmentUserStatusState(int assessmentUserStatusId);
        Task<IEnumerable<AssessmentUserStateModel>> GeAssessmentExceptUserInList(int[] userIds, int? permissionId, string siteCode, int? formTypeId);
        Task<IReadOnlyCollection<UserFormAndStatusModel>> GetEmployeeFormType(string[] twwids);
        Task<GenericHttpResponseMessageModel> UpdateForm(UpdateEmployeeFormDTO updateEmployeeFormDTO);
        Task<IReadOnlyCollection<AssessmentUserStateModel>> GetEmployeeAssessmentDetail(int[] twwids, int? formTypeId);
        Task<bool> ResetLockAndPinByAssessmentUserStatusIds(IReadOnlyCollection<int> assessmentUserStatusIds);
        Task<ResponseModel> DeleteAssessmentUserComment(int AssessmentUserCommentId);
        Task<ResponseModel> InsertAssessmentLinkForm(AssessmentLinkFormDTO assessmentLinkFormDTO);
        Task<bool> DeleteAssessmentLinkFormById(int id);
        Task<bool> DeleteAssessmentLinkForm(int assessmentUserStatusId);
        Task<ResponseModel> UpdateAssessmentLinkForm(int id, AssessmentLinkFormDTO assessmentLinkFormDTO);
        Task<bool> UpdateTemplateToNewVersion(AssessmentUserStatusTemplateDTO assessmentUserStatusTemplateDTO);
    }
}
