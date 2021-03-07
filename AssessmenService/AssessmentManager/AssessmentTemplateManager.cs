using AssessmentPersistence;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentTemplateManager : IAssessmentTemplateManager
    {
        private readonly IAssessmentTemplatePersistence _assessmentTemplatePersistence;
        private readonly IAssessmentQuestionsPersistence _assessmentQuestionsPersistence;
        public AssessmentTemplateManager(IAssessmentTemplatePersistence assessmentTemplatePersistence,
            IAssessmentQuestionsPersistence assessmentQuestionsPersistence)
        {
            _assessmentTemplatePersistence = assessmentTemplatePersistence;
            _assessmentQuestionsPersistence = assessmentQuestionsPersistence;
        }
        public async Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates()
        {
            var result = await _assessmentTemplatePersistence.GetAllAssessmentTemplates();

            if (result == null)
                throw new InvalidOperationException("No assessment found.");

            return result;
        }

        public async Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates(int year)
        {
            if (year.ToString().Length != 4 || year <= 0)
                throw new ArgumentException("Year is not in correct format. Expected YYYY.");

            var result = await _assessmentTemplatePersistence.GetAllAssessmentTemplates(year);

            if (result == null)
                throw new InvalidOperationException("No assessment found for the provided year.");

            return result;

        }

        public async Task<IReadOnlyCollection<AssessmentFormTypeModel>> GetAssessmentFormTypesAsync()
        {
            var result = await _assessmentTemplatePersistence.GetAssessmentFormTypesAsync();

            if (result == null)
                throw new InvalidOperationException("No assessment forms found.");

            return result;
        }


    }
}
