using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AssessmentPersistence.Entities.LookUpTables
{
    /**
     * Table for list of Category Codes and their description
     * CategoryCode can be repeated
     * This will used to reference CategoryCode to a different CategoryDom
     * since some CategoryCode has different Dom elements
     * in some version
     */
    public class AssessmentCategory
    {
        [Key]
        public int Id { get; set; }
        public string CategoryCode { get; set; }
        [ForeignKey("CategoryCode")]
        public Category Category { get; set; }
        public string Description { get; set; }
        public IReadOnlyCollection<CategoryDom> CategoryDoms { get; set; }
        public IReadOnlyCollection<TemplateCategoryOrder> TemplateCategoryOrders { get; set; }
    }
}
