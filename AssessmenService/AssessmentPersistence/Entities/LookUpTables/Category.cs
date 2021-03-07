using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class Category
    {
        [Key]
        public string CategoryCode { get; set; }
        public IReadOnlyCollection<Questionnaire> Questionnaires { get; set; }
        public IReadOnlyCollection<AssessmentCategory> AssessmentCategories { get; set; }
    }
}
