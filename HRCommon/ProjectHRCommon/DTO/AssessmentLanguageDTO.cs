using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentLanguageDTO
    {
        public int TemplateId { get; set; }
        public string LanguageCode { get; set; }
    }
}
