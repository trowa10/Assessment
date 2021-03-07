using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UserExcludeDTO
    {
        [JsonProperty("twwId")]
        public int TwwId { get; set; }

        [JsonProperty("isExclude")]
        public bool IsExclude { get; set; }
    }
}
