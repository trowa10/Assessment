using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusCategoryDTO
    {
        [JsonProperty("assessmentUserStatusId")]
        public int AssessmentUserStatusId { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }
    }
}
