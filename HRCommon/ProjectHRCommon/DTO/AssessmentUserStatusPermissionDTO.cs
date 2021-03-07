using ProjectHRCommon.Enum;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusPermissionDTO
    {
        public int ModifyBy { get; set; }      
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public int ReportsTo { get; set; }
        public int UserRegionId { get; set; }
        public string SiteCode { get; set; }
        public int Status { get; set; }

    }
}
