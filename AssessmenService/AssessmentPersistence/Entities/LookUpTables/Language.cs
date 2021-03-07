using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
    
namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
