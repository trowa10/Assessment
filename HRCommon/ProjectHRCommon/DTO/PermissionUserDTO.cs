using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class PermissionUserDTO
    {
        [JsonProperty("permissionId")]
        public int PermissionId { get; set; }
        [JsonProperty("twwId")]
        public int TwwId { get; set; }
    }
}
