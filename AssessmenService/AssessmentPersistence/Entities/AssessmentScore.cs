using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities
{
    [ExcludeFromCodeCoverage]
    //unfortunately we can't create a separate service for lookup table so we it here
    public class AssessmentScore
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int ScoreCriteriaId { get; set; }
    }
}
