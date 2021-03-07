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
    [Route("assess-service/api/v{v:apiVersion}/[controller]")]
    [ApiController]
    [Authorize(Policy = "VerifiedTokenOnly")]
    [EnableCors("ProjectHRCors")]
    public class AssessmentLanguageController : ControllerBase
    {
        private readonly IAssessmentLanguageManager _assessmentLanguageManager;
        public AssessmentLanguageController(IAssessmentLanguageManager assessmentLanguageManager)
        {
            _assessmentLanguageManager = assessmentLanguageManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _assessmentLanguageManager.GetLanguagesAsync());
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}