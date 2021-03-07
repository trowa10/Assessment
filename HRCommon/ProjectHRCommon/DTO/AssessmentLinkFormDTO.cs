using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;


namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentLinkFormDTO
    {
        [JsonProperty("assessmentUserStatusId")]
        public int AssessmentUserStatusId { get; set; }

        [JsonProperty("linkedAssessmentUserStatusId")]
        public int LinkedAssessmentUserStatusId { get; set; }

        [JsonProperty("createdByTwwId")]
        public int CreatedByTwwId { get; set; }
    }
}
