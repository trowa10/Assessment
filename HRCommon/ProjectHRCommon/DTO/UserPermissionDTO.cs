using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class UserPermissionDTO
    {
        public int UserId { get; set; }
        public int RegionId { get; set; }
        public int PermissionId { get; set; }
        public string SiteCode { get; set; }
        public bool IsActive { get; set; }  
        public bool IsAdmin { get; set; }
        
    }
}
