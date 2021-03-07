
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AnswerDomInfoModel
    {

        private readonly int _domId;
        private readonly string _categoryCode;
        private readonly string _questionCode;
        private readonly string _answerText;
        private readonly int _points; //score
        private readonly string _style;
        private readonly double _order;
        private readonly bool _isRequired;
        private readonly string _elementName;
        public AnswerDomInfoModel(int id, int answerId, int domId, string categoryCode, string questionCode, string answerText
            , int points, string style, double order, bool isRequired, string elementName)
        {
            _domId = domId;
            _categoryCode = categoryCode;
            _questionCode = questionCode;
            _answerText = answerText;
            _points = points;
            _style = style;
            _order = order;
            _isRequired = isRequired;
            _elementName = elementName;
        }


        public int DomId => _domId;

        public string CategoryCode => _categoryCode;

        public string QuestionCode => _questionCode;

        public string AnswerText => _answerText;

        public int Points => _points;

        public string Style => _style;

        public double Order => _order;

        public bool IsRequired => _isRequired;

        public string ElementName => _elementName;
    }
}
