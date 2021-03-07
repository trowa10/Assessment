using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentLinkFormUpdateDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("assessmentUserStatusId")]
        public int AssessmentUserStatusId { get; set; }

        [JsonProperty("linkedAssessmentUserStatusId")]
        public int LinkedAssessmentUserStatusId { get; set; }

        [JsonProperty("createdByTwwId")]
        public int CreatedByTwwId { get; set; }


    }
}
