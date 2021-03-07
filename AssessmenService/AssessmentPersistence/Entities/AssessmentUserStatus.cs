using AssessmentPersistence.Abstract;
using AssessmentPersistence.Entities.LookUpTables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatus : AssessmentBaseClass
    {
        /* <summary>
         * The table for the current status of the employee in the current assessmentForm        
         * </summary>
         */
        public int AssessmentTemplateId { get; set; }

        [ForeignKey("AssessmentTemplateId")]
        public AssessmentTemplate AssessmentTemplate { get; set; }

        public int UserId { get; set; } //TWWID

        public int StatusId { get; set; }

        public int ReportsTo { get; set; }

        public int EmployeeLevelId { get; set; }

        [ForeignKey("EmployeeLevelId")]
        public AssessmentScore AssessmentScore { get; set; }

        public int UserRegionId { get; set; }

        public string SiteCode { get; set; }

        public int LockedToUserId { get; set; } //TWWID who locked the form

        public string Pin { get; set; }

        public bool formChanged { get; set; }

        public IReadOnlyCollection<AssessmentUserComment> AssessmentUserComments { get; set; }
    }
}
