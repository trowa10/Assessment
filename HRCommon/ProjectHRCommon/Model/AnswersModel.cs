
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AnswersModel
    {
        private readonly int _id;
        private readonly int _answerId;
        private readonly int _domId;
        private readonly string _categoryCode;
        private readonly string _questionCode;
        private readonly string _answerText;
        private readonly int _points; //score

        public AnswersModel() { }
        public AnswersModel(int id, int answerId, int domId, string categoryCode, string questionCode, string answerText
            , int points)
        {
            _id = id;
            _answerId = answerId;
            _domId = domId;
            _categoryCode = categoryCode;
            _questionCode = questionCode;
            _answerText = answerText;
            _points = points;
        }

        public int Id => _id;

        public int AnswerId => _answerId;

        public int DomId => _domId;

        public string CategoryCode => _categoryCode;

        public string QuestionCode => _questionCode;

        public string AnswerText => _answerText;

        public int Points => _points;
    }
}
