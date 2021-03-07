using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UserDTO
    {
        [JsonProperty("twwId")]
        public string TwwId { get; set; }
    }
}
