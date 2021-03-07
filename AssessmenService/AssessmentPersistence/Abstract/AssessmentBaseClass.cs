using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Abstract
{
    [ExcludeFromCodeCoverage]
    public abstract class AssessmentBaseClass
    {
        public AssessmentBaseClass()
        {
            DateModified = DateTime.UtcNow;
            DateCreated = DateTime.UtcNow;
            IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int ModifiedBy { get; set; }

        public bool IsActive { get; set; }
       
    }
}
