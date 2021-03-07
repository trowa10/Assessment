using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model.QuestionnaireModels
{
    [ExcludeFromCodeCoverage]
    public class CategoryTemplateModel
    {
        private readonly string _categoryCode;
        private readonly double _categoryOrder;
        private readonly DomModel[] _domList;

        public CategoryTemplateModel(string categoryCode, double categoryOrder, DomModel[] domList)
        {
            _categoryCode = categoryCode;
            _categoryOrder = categoryOrder;
            _domList = domList;
        }

        public string CategoryCode => _categoryCode;

        public double CategoryOrder => _categoryOrder;

        public DomModel[] DomList => _domList;
    }
}
