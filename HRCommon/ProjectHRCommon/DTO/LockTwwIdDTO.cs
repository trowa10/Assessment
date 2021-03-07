using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{

    [ExcludeFromCodeCoverage]
    public class LockTwwIdDTO
    {
        [JsonProperty("lockTwwId")]
        public int TwwId { get; set; }

        public static explicit operator LockTwwIdDTO(int twwid)
        {
            return new LockTwwIdDTO() { TwwId = twwid };
        }

        public static explicit operator int(LockTwwIdDTO lockTwwIdDTO)
        {
            return lockTwwIdDTO.TwwId;
        }
    }
}
