using System.Diagnostics.CodeAnalysis;


namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class QuestionTemplateModel
    {
        private readonly string _categoryCode;
        private readonly string _questionCode;
        private readonly double _questionOrder;
        private readonly DomModel[] _domList;

        public QuestionTemplateModel(string categoryCode, string questionCode, double questionOrder, DomModel[] domList)
        {
            _categoryCode = categoryCode;
            _questionCode = questionCode;
            _questionOrder = questionOrder;
            _domList = domList;
        }

        public string CategoryCode => _categoryCode;

        public string QuestionCode => _questionCode;

        public double QuestionOrder => _questionOrder;

        public DomModel[] DomList => _domList;
    }
}
