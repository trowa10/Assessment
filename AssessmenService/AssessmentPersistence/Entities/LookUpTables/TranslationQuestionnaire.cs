using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class TranslationQuestionnaire
    {
        [Key]
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string QuestionsJson { get; set; }
    }
}
