using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusActionLockDTO
    {
        [JsonProperty("assessmentuserstatusid")]
        public int AssessmentUserStatusId { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("lockTwwId")]
        public int TwwId { get; set; }

        [JsonProperty("pin")]
        public string Pin { get; set; }
    }
}
