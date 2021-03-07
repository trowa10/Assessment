using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class Questionnaire
    {
        [Key]
        public int Id { get; set; }
        public string CategoryCode { get; set; }
        public Category Category { get; set; }
        public string QuestionCode { get; set; }
        public IReadOnlyCollection<TemplateQuestionnaire> TemplateQuestionnaires { get; set; }
        public IReadOnlyCollection<QuestionnaireDom> QuestionnaireDoms { get; set; }
    }
}
