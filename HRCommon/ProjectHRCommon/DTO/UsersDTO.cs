using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UsersDTO
    {
        [JsonProperty("twwIds")]
        public int[] TwwIds { get; set; }
    }
}
