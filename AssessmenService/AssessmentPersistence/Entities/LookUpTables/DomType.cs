using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentPersistence.Entities.LookUpTables
{
   public class DomType
    {
        [Key]
        public int TypeId { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<Dom> Doms { get; set; }
    }
}
