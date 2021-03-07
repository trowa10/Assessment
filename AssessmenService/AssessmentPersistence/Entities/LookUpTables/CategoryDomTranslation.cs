using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class CategoryDomTranslation
    {
        [Key]
        public int Id { get; set; }
        public int CategoryDomId { get; set; }
        [ForeignKey("CategoryDomId")]
        public CategoryDom CategoryDom { get; set; }
        public int TranslationId { get; set; }
        [ForeignKey("TranslationId")]
        public Translation Translation { get; set; }
    }
}
