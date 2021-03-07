using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class AssessmentLinkForm
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AssessmentUserStatus")]
        public int AssessmentUserstatusId { get; set; }

        [ForeignKey("AssessmentUserStatus")]
        public int LinkedAssessmentUserstatusId { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
