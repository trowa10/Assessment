using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class PermissionUsersDTO
    {
        [JsonProperty("permissionId")]
        public int PermissionId { get; set; }
        [JsonProperty("users")]
        public UsersDTO Users { get; set; }
    }
}
