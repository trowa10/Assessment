using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{

    [ExcludeFromCodeCoverage]
    public class AssessmentUserAnswerDTO
    {
        [Required]
        public int AssessmentUserStatusId { get; set; }
        public int TotalScore { get; set; }
        public int StatusId { get; set; }
        public int EmployeeLevelId { get; set; }
        public string AnswersJson { get; set; }
        public IReadOnlyCollection<AnswerDTO> Answers { get; set; } //for v2
        public DateTime? DateManagerApproved { get; set; }
        public DateTime? DateEmployeeApproved { get; set; }
        public int ModifiedBy { get; set; }
        public string LanguageCode { get; set; }
        public int ApproverTwwId { get; set; }
        public bool ShowEmpLevel { get; set; }
    }
}
