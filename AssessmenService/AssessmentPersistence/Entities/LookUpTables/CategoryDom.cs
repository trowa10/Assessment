using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class CategoryDom
    {
        public CategoryDom()
        {
            this.DateTimeUtc = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }
        public int AssessmentCategoryId { get; set; }
        [ForeignKey("AssessmentCategoryId")]
        public AssessmentCategory AssessmentCategory { get; set; }
        public int DomId { get; set; }
        [ForeignKey("DomId")]
        public Dom Dom { get; set; }
        public double CategoryDomOrder { get; set; }
        public DateTime DateTimeUtc { get; set; }
        public IReadOnlyCollection<CategoryDomTranslation> CategoryDomTranslations { get; set; }
    }
}
