using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class QuestionnaireDomTranslation
    {
        [Key]
        public int Id { get; set; }
        public int QuestionnaireDomId { get; set; }
        [ForeignKey("QuestionnaireDomId")]
        public QuestionnaireDom QuestionnaireDom { get; set; }
        public int TranslationId { get; set; }
        [ForeignKey("TranslationId")]
        public Translation Translation { get; set; }


    }
}
