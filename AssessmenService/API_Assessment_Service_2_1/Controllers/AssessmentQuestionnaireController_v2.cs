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
    [ApiVersion("2.0")]
    [ApiController]
    [Authorize(Policy = "VerifiedTokenOnly")]
    [EnableCors("ProjectHRCors")]
    public class AssessmentQuestionnaireController_v2 : ControllerBase
    {
        private readonly IAssessmentQuestionnaireManager _assessmentQuestionnaireManager;

        public AssessmentQuestionnaireController_v2(IAssessmentQuestionnaireManager assessmentQuestionnaireManager)
        {
            _assessmentQuestionnaireManager = assessmentQuestionnaireManager;
        }


        [HttpGet]
        [Route("template/{id}")]
        public async Task<IActionResult> GetTemplateQuesionnaire(int id, [FromQuery(Name = "languageCode")] string languageCode)
        {
            try
            {
                var result = await _assessmentQuestionnaireManager.GetTemplateQuestionnaireByTemplateId(id, languageCode);

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
                return Ok(await _assessmentQuestionnaireManager.GetAssessmentQuestionnaireDetail_v2(id, userId, isNoLocked));
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
                return Ok(await _assessmentQuestionnaireManager.UpsertAnswers_v2(assessmentAnswerDTO));
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
                return Ok(await _assessmentQuestionnaireManager.AutoUpsertAnswers_v2(assessmentAnswerDTO));
            }
            catch (ArgumentException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
