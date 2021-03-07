using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class TemplateCategoryOrder
    {
        [Key]
        public int Id { get; set; }
        public int AssessmentTemplateId { get; set; }
        [ForeignKey("AssessmentTemplateId")]
        public AssessmentTemplate AssessmentTemplate { get; set; }
        public int AssessmentCategoryId { get; set; }
        [ForeignKey("AssessmentCategoryId")]
        public AssessmentCategory AssessmentCategory { get; set; }
        public double CategoryOrder { get; set; }
    }
}
