using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class QuestionnaireDom
    {
        public QuestionnaireDom()
        {
            this.DateTimeUtc = DateTime.UtcNow;
        }
        [Key]
        public int Id { get; set; }
        public int QuestionnaireId { get; set; }
        [ForeignKey("QuestionnaireId")]
        public Questionnaire Questionnaire { get; set; }
        public int DomId { get; set; }
        public Dom Dom { get; set; }
        public double QuestionnaireDomOrder { get; set; }

        public DateTime DateTimeUtc { get; set; }
        public IReadOnlyCollection<QuestionnaireDomTranslation> QuestionnaireDomTranslations { get; set; }
    }
}
