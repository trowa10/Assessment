using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentTemplatePermissionDTO
    {
        public int TemplateId { get; set; }
        public int PermissionId { get; set; }
    }
}
