using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserCommentDTO
    {
        [JsonProperty("assessmentUserStatusId")]
        public int AssessmentUserStatusId { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("twwId")]
        public int TwwId { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }
}
