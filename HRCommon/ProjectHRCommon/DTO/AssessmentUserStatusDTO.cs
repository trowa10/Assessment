using ProjectHRCommon.Enum;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusDTO
    {
        public int ModifyBy { get; set; }
        public int TemplateId { get; set; }
        public int UserId { get; set; }
        public int ReportsTo { get; set; }
        public int EmployeeLevelId { get; set; }
        public int UserRegionId { get; set; }
        public string SiteCode { get; set; }
        public AssessmentState Status { get; set; }
    }
}
