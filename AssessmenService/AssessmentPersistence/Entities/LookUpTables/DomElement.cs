using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentPersistence.Entities.LookUpTables
{
   public class DomElement
    {
        [Key]
        public int ElementId { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<Dom> Doms { get; set; }
    }
}
