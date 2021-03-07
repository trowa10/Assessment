using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class TemplatePermission
    {
        [Key]
        public int Id { get; set; }
        public int AssessmentTemplateId { get; set; }

        [ForeignKey("AssessmentTemplateId")]
        public AssessmentTemplate AssessmentTemplate { get; set; }
        public int PermissionId { get; set; }
    }
}
