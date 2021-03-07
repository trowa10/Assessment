using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusTemplateDTO
    {
        public int AssessmentUserStatusId { get; set; }
        public int TemplateId { get; set; }
        public int ModifyBy { get; set; }
    }
}
