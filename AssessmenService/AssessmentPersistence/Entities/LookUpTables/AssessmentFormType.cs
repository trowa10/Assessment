using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class AssessmentFormType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }     
    }
}
