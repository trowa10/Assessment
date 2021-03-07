using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class PinDTO
    {
        [JsonProperty("pin")]
        public string Pin { get; set; }

        public static explicit operator PinDTO(string pin)
        {
            return new PinDTO() { Pin = pin };
        }

    }
}
