using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserComment
    {
        [Key]
        public int Id { get; set; }
        public string CategoryCode { get; set; }
        public int AssessmentUserStatusId { get; set; }      
        public int TwwId { get; set; }        
        public int ParentId { get; set; }
        public bool IsEdited { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string Comments { get; set; }

        [ForeignKey("AssessmentUserStatusId")]
        public AssessmentUserStatus AssessmentUserStatus { get; set; }
    }
}
