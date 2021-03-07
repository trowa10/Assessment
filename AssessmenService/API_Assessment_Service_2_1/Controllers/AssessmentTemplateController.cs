using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AssessmentManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API_Assessment_Service_2_1.Controllers
{

    [ExcludeFromCodeCoverage]

    [ApiVersion("1.0")]
    [Route("assess-service/api/v{v:apiVersion}/templates")]
    [ApiController]
    [Authorize(Policy = "VerifiedTokenOnly")]
    [EnableCors("ProjectHRCors")]
    public class AssessmentTemplateController : ControllerBase
    {
        private readonly IAssessmentTemplateManager _assessmentTemplateManager;

        public AssessmentTemplateController(IAssessmentTemplateManager assessmentTemplateManager)
        {
            _assessmentTemplateManager = assessmentTemplateManager;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAssessment([FromQuery]int? year)
        {
          
            try
            {
                if (year == null)
                {
                    var result = await _assessmentTemplateManager.GetAllAssessmentTemplates();

                    return Ok(new { message = "success", result = result });
                }
                else
                {
                    var result = await _assessmentTemplateManager.GetAllAssessmentTemplates((int)year);

                    return Ok(new { message = "success", result = result });
                }

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
        [Route("formtypes")]
        public async Task<IActionResult> GetAssessmentFormTypesAsync()
        {

            try
            {
                var result = await _assessmentTemplateManager.GetAssessmentFormTypesAsync();

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
    }
}