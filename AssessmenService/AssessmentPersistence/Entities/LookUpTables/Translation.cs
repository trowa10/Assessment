using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class Translation
    {
        [Key]
        public int Id { get; set; }
        public string LanguageCode { get; set; }
        public string Text { get; set; }

        public IReadOnlyCollection<QuestionnaireDomTranslation> QuestionnaireDomTranslations { get; set; }

        public IReadOnlyCollection<CategoryDomTranslation> CategoryDomTranslations { get; set; }
    }
}
