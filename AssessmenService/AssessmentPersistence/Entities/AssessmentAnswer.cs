using AssessmentPersistence.Abstract;
using AssessmentPersistence.Entities.LookUpTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities
{
    [ExcludeFromCodeCoverage]
    public class AssessmentAnswer : AssessmentBaseClass
    {
        public int AssessmentUserStatusId { get; set; }

        [ForeignKey("AssessmentUserStatusId")]
        public AssessmentUserStatus AssessmentUserStatus { get; set; }

        public int TotalScore { get; set; }

        public string AnswersJson { get; set; }

        public string LanguageCode { get; set; }

        public int ApproverTwwId { get; set; }

        public DateTime? DateManagerApproved { get; set; }

        public DateTime? DateEmployeeApproved { get; set; }

        public DateTime? DateTimeSubmitted { get; set; }

        public bool? ShowEmpLevel { get; set; }
        public IReadOnlyCollection<Answer> Answers { get; set; }
    }
}
