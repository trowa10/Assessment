using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model.QuestionnaireModels
{
    [ExcludeFromCodeCoverage]
    public class QuestionnaireTemplateModel
    {
        private readonly CategoryTemplateModel _category;
        private readonly QuestionTemplateModel[] _questions;

        public QuestionnaireTemplateModel(CategoryTemplateModel category, QuestionTemplateModel[] questions)
        {
            _category = category;
            _questions = questions;
        }

        public CategoryTemplateModel Category => _category;

        public QuestionTemplateModel[] Questions => _questions;
    }
}
