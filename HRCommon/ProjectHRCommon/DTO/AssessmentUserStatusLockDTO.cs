using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusLockDTO
    {
        [JsonProperty("assessmentUserStatusId")]
        public int AssessmentUserStatusId { get; set; }
        [JsonProperty("lockpindto")]
        public LockPinDTO LockPinDTO { get; set; }

    }
}
