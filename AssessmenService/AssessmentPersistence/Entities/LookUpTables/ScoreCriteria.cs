using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class ScoreCriteria
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
