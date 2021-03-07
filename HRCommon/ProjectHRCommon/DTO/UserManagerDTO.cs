using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UserManagerDTO
    {
        [JsonProperty("twwid")]
        public string TwwId { get; set; }
        [JsonProperty("actualmanagertwwid")]
        public string ActualManagerTwwId { get; set; }

    }
}
