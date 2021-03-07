using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.DTO
{
    [ExcludeFromCodeCoverage]
    public class AssessmentResultForSubmit2DTO
    {
        public int Id { get; set; }
        public int twwId { get; set; }
        public int managerId { get; set; }
        public string question_1 { get; set; }
        public string question_2 { get; set; }
        public string question_3 { get; set; }
        public string question_4 { get; set; }
        public string question_5 { get; set; }
        public string question_6 { get; set; }
        public string question_7 { get; set; }
        public string question_8 { get; set; }

        public string result_1 { get; set; }
        public string result_2 { get; set; }
        public string result_3 { get; set; }
        public string result_4 { get; set; }
        public string result_5 { get; set; }
        public string result_6 { get; set; }
        public string result_7 { get; set; }
        public string result_8 { get; set; }

    }
}
