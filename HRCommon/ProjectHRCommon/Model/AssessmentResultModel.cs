using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentResultModel
    {
        private readonly int _id;
        private readonly int? _assessmentUserStateId;
        private readonly int? _questionId;
        private readonly string _question;
        private readonly string _result;

        public AssessmentResultModel(int id, int? assessmentUserStateId, int? questionId, string question, string result)
        {
            _id = id;
            _assessmentUserStateId = assessmentUserStateId;
            _questionId = questionId;
            _question = question;
            _result = result;
        }

        public int Id => _id;

        public int? AssessmentUserStateId => _assessmentUserStateId;

        public int? QuestionId => _questionId;

        public string Question => _question;

        public string Result => _result;
    }
}
