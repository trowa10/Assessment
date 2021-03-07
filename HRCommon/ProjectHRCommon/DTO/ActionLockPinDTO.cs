using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class ActionLockPinDTO
    {
        [JsonProperty("action")]
        public ActionDTO ActionDTO { get; set; }

        [JsonProperty("lockpindto")]
        public LockPinDTO LockPinDTO { get; set; }

    }

}
