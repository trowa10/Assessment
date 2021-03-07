using AssessmentManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectHRCommon.DTO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace API_Assessment_Service_2_1.Controllers
{
    [ExcludeFromCodeCoverage]
 
    [Route("assess-service/api/v{v:apiVersion}/[controller]")]
    [ApiController]
    [Authorize(Policy = "VerifiedTokenOnly")]
    [EnableCors("ProjectHRCors")]
    public class AssessmentUserStatusController : ControllerBase
    {
        private readonly IAssessmentUserStatusManager _assessmentUserStatusManager;
        private readonly IAssessmentAnswerManager _assessmentAnswerManager;

        public AssessmentUserStatusController(IAssessmentUserStatusManager assessmentUserStatusManager,
            IAssessmentAnswerManager assessmentAnswerManager)
        {

            _assessmentUserStatusManager = assessmentUserStatusManager;
            _assessmentAnswerManager = assessmentAnswerManager;
        }

        [HttpPost]
        [ApiVersion("1.0")]
        [Route("UpdateAssessmentUserState")]
        public async Task<IActionResult> UpdateAssessmentUserState([FromBody] AssessmentUserStateDTO assessmentUserSateDTO)
        {
            try
            {
                return Ok(await _assessmentUserStatusManager.UpdateAssessmentStatus(assessmentUserSateDTO));
            }
            catch (ArgumentException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { error = "Ooops! there something wrong while updating." });
            }
        }

        [HttpPost]
        [ApiVersion("1.0")]
        [Route("UpdateStateClearAnswerIfNotDone")]
        public async Task<IActionResult> UpdateAssessmentUserStateClearAnswerIfNotDone([FromBody] AssessmentUserStateDTO[] assessmentUserSateDTO)
        {
            return Ok(await _assessmentUserStatusManager.UpdateAssessmentUserStateClearAnswerIfNotDone(assessmentUserSateDTO.ToList()));
        }


        [HttpPost]
        [ApiVersion("1.0")]
        [Route("Insert")]
        public async Task<IActionResult> InsertAssessmentUserStatus([FromBody] AssessmentUserStatusPermissionDTO[] assessmentUserStatusPermissionDTOs)
        {
            return Ok(await _assessmentUserStatusManager.BulkInsertOrUpdateAssessmentUserStatus(assessmentUserStatusPermissionDTOs.ToList()));
        }

        [HttpPatch]
        [ApiVersion("1.0")]
        [Route("Update")]
        public async Task<IActionResult> UpdateAssessmentUserStatusTemplateId([FromBody] AssessmentUserStatusTemplateDTO assessmentUserStatusTemplateDTO)
        {
            return Ok(await _assessmentUserStatusManager.UpdateAssessmentStatusTemplate(assessmentUserStatusTemplateDTO));
        }

        [HttpGet]
        [ApiVersion("1.0")]
        [Route("state/{id}")]
        public async Task<IActionResult> GetAssessmentUserStatus(int id)
        {

            return Ok(await _assessmentUserStatusManager.GetAssessmentUserStatusState(id));
        }

        //Get the assessments of users except twwid of Excluded users, hrm except current user, hrbp except current user
        //currently used by hrm,hrbp role
        [HttpPost]
        [ApiVersion("1.0")]
        [Route("summaryExceptTwwids")]
        public async Task<IActionResult> GeAssessmentExceptUserInList([FromBody] AssessmentUserStatusFiltersDTO assessmentUserFilters)
        {
            return Ok(await _assessmentUserStatusManager.GeAssessmentExceptUserInList(assessmentUserFilters.TwwIds, assessmentUserFilters.PermissionId, assessmentUserFilters.SiteCode, assessmentUserFilters.FormTypeId));
        }

        //Get the assessments of users by twwid currently used by manager role
        [HttpPost]
        [ApiVersion("1.0")]
        [Route("summarybytwwids")]
        public async Task<IActionResult> GetEmployeeAssessmentDetail([FromBody] AssessmentUserStatusFiltersDTO assessmentUserFilters)
        {
            return Ok(await _assessmentUserStatusManager.GetEmployeeAssessmentDetail(assessmentUserFilters.TwwIds, assessmentUserFilters.FormTypeId));
        }

        [HttpPost]
        [Route("userform")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetEmployeeFormType([FromBody] TwwidStringListDTO twwids)
        {
            return Ok(await _assessmentUserStatusManager.GetEmployeeFormType(twwids.TwwIds));
        }

        [HttpPost]
        [Route("updateEmployeeForm")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> UpdateForm([FromBody] UpdateEmployeeFormDTO updateEmployeeFormDTO)
        {
            return Ok(await _assessmentUserStatusManager.UpdateForm(updateEmployeeFormDTO));
        }

        [HttpPost]
        [Route("lockpinbyaction")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GenerateAssessmentUserStatusByAction([FromBody] AssessmentUserStatusActionLockDTO assessmentUserStatusActionLockDTO)
        {
            return Ok(await _assessmentUserStatusManager.GenerateAssessmentUserStatusByAction(assessmentUserStatusActionLockDTO));
        }

        [HttpPost]
        [Route("resetLockAndPin")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> ResetLockAndPinByAssessmentUserStatusIds([FromBody] UpdateAssessmentUserStatusListDTO updateAssessmentUserStatusListDTO)
        {
            return Ok(await _assessmentUserStatusManager.ResetLockAndPinByAssessmentUserStatusIds(updateAssessmentUserStatusListDTO.AssessmentUserStatusIds));
        }

        [HttpGet]
        [Route("getuserformlocktoassistingmanager")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetAssessmentUserFormLockToAssistingManager(int twwid, int assistingtwwid)
        {
            return Ok(await _assessmentUserStatusManager.GetAssessmentUserFormLockToAssistingManager(twwid, assistingtwwid));
        }

        [HttpPost]
        [Route("userforms")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetAssessmentUserForms([FromBody] UserManagerDTO userManagerDTO)
        {
            return Ok(await _assessmentUserStatusManager.GetAssessmentUserForm(userManagerDTO));
        }

        [HttpGet]
        [Route("formscompletedbytwwid")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetAssessmentUserCompletedForms(int twwid)
        {
            return Ok(await _assessmentUserStatusManager.GetAssessmentUserCompletedForms(twwid));
        }


        [HttpPost]
        [Route("usercomments")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetAssessmentuserComments([FromBody] AssessmentUserStatusCategoryDTO assessmentUserStatusCategoryDTO)
        {
            return Ok(await _assessmentUserStatusManager.GetAssessmentUserComments(assessmentUserStatusCategoryDTO));
        }

        [HttpPost]
        [Route("insertcomments")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> InsertComments([FromBody] AssessmentUserCommentDTO assessmentUserCommentDTO)
        {
            return Ok(await _assessmentUserStatusManager.InsertAssessmentUserComment(assessmentUserCommentDTO));
        }

        [HttpDelete]
        [Route("deletecomment/{id}")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            return Ok(await _assessmentUserStatusManager.DeleteAssessmentUserComment(id));
        }

        [HttpPut]
        [Route("updatecomment")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> UpdateComment([FromBody]AssessmentUserCommentUpdateDTO assessmentUserCommentUpdateDTO)
        {
            return Ok(await _assessmentUserStatusManager.UpdateComment(assessmentUserCommentUpdateDTO));
        }

        [HttpPost]
        [Route("insertformlink")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> InsertFormLink([FromBody] AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            return Ok(await _assessmentUserStatusManager.InsertAssessmentLinkForm(assessmentLinkFormDTO));
        }

        [HttpDelete]
        [Route("deleteformlinkbyid/{id}")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> DeleteFormById(int id)
        {
            return Ok(await _assessmentUserStatusManager.DeleteAssessmentLinkFormById(id));
        }

        [HttpDelete]
        [Route("deleteformlink/{assessmentuserstatusid}")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> DeleteForm(int assessmentUserStatusId)
        {
            return Ok(await _assessmentUserStatusManager.DeleteAssessmentLinkForm(assessmentUserStatusId));
        }

        [HttpPut]
        [Route("updateformlink/{id}")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> UpdateForm(int id, [FromBody] AssessmentLinkFormDTO assessmentLinkFormDTO)
        {
            return Ok(await _assessmentUserStatusManager.UpdateAssessmentLinkForm(id, assessmentLinkFormDTO));
        }

        [HttpPatch]
        [Route("UpdateTemplateToNewVersion")]
        [ApiVersion("1.0")]
        public async Task<IActionResult> UpdateTemplateToNewVersion([FromBody] AssessmentUserStatusTemplateDTO assessmentUserStatusTemplateDTO)
        {
            try
            {
                return Ok(await _assessmentUserStatusManager.UpdateTemplateToNewVersion(assessmentUserStatusTemplateDTO));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [ApiVersion("2.0")]
        [Route("migrateanswers")]
        public async Task<IActionResult> GetMigratedAnswers(int currentId, int doneId)
        {
            return Ok(await _assessmentAnswerManager.GetAssessmentMigrateAnswers(currentId, doneId));
        }

    }
}
