using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class LockPinDTO
    {     
        [JsonProperty("lockTwwId")]
        public LockTwwIdDTO LockTwwIdDTO { get; set; }
        [JsonProperty("Pin")]
        public PinDTO PinDTO { get; set; }
    }

}
