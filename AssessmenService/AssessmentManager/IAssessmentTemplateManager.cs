using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentTemplateManager
    {
        Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates();
        Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates(int year);
        Task<IReadOnlyCollection<AssessmentFormTypeModel>> GetAssessmentFormTypesAsync();

    }
}
