using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AssessmentManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectHRCommon.DTO;

namespace API_Assessment_Service_2_1.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("assess-service/api/v{v:apiVersion}/questionnaire")]
    [ApiVersion("1.0")]
    [ApiController]
    [Authorize(Policy = "VerifiedTokenOnly")]
    [EnableCors("ProjectHRCors")]
    public class AssessmentQuestionnaireController : ControllerBase
    {
        private readonly IAssessmentQuestionnaireManager _assessmentQuestionnaireManager;

        public AssessmentQuestionnaireController(IAssessmentQuestionnaireManager assessmentQuestionnaireManager)
        {
            _assessmentQuestionnaireManager = assessmentQuestionnaireManager;
        }

        [HttpPost]
        [Route("localize")]
        public async Task<IActionResult> Get([FromBody] AssessmentLanguageDTO assessmentLanguageDTO)
        {
            return Ok(await _assessmentQuestionnaireManager.GetQuestionnaireByTemplateLanguage(assessmentLanguageDTO));
        }

        [HttpGet("template/{id}")]
        public async Task<IActionResult> GetAssessmentTemplateQuestionnaire(int id)
        {

            try
            {
                var result = await _assessmentQuestionnaireManager.GetQuestionnaireByTemplateId(id);

                return Ok(new { message = "success", result = result });

            }
            catch (InvalidOperationException ex)
            {
                return NotFound(new { message = ex.Message, result = "" });

                throw;
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { message = ex.Message, result = "" });

                throw;
            }
        }

        [HttpGet]
        [Route("result/{id}")]
        public async Task<IActionResult> GetAssessmentDetail(int id, int userId, bool isNoLocked = false)
        {
            try
            {
                return Ok(await _assessmentQuestionnaireManager.GetAssessmentQuestionnaireDetail(id, userId, isNoLocked));
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("result/save")]
        public async Task<IActionResult> UpsertAnswers([FromBody] AssessmentAnswerDTO assessmentAnswerDTO)
        {
            try
            {
                return Ok(await _assessmentQuestionnaireManager.UpsertAnswers(assessmentAnswerDTO));
            }
            catch (ArgumentException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("result/autosave")]
        public async Task<IActionResult> AutoUpsertAnswers([FromBody] AssessmentAnswerDTO assessmentAnswerDTO)
        {
            try
            {
                return Ok(await _assessmentQuestionnaireManager.AutoUpsertAnswers(assessmentAnswerDTO));
            }
            catch (ArgumentException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("latestversion/{assessmentUserStatusId}")]
        public async Task<IActionResult> GetAssessmentLatestVersion(int assessmentUserStatusId)
        {
            try
            {
                return Ok(await _assessmentQuestionnaireManager.GetTemplateLatestVersion(assessmentUserStatusId));
            }
            catch (ArgumentException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
