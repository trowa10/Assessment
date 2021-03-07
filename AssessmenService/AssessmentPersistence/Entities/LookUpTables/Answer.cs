using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class Answer
    {
        public Answer()
        {
            this.DateTimeCreatedUtc = DateTime.UtcNow;
        }
        [Key]
        public int Id { get; set; }
        public int AssessmentAnswerId { get; set; }
        [ForeignKey("AssessmentAnswerId")]
        public AssessmentAnswer AssessmentAnswer { get; set; }
        public int DomId { get; set; }
        public Dom Dom { get; set; }
        public string CategoryCode { get; set; }
        public Category Category { get; set; }
        public string QuestionCode { get; set; }
        public string AnswerText { get; set; }
        public int Points { get; set; }
        public DateTime DateTimeCreatedUtc { get; set; }

    }
}
