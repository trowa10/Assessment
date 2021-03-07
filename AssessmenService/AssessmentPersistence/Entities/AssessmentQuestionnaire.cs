using AssessmentPersistence.Entities.LookUpTables;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities
{
    [ExcludeFromCodeCoverage]
    public class AssessmentQuestionnaire
    {
        [Key]
        public int Id { get; set; }

        public int AssessmentTemplateId { get; set; }
        public AssessmentTemplate assessmentTemplate { get; set; }
        public int TranslationQuestionnaireId { get; set; }
        public TranslationQuestionnaire translationQuestionnaire { get; set; }
    }
}
