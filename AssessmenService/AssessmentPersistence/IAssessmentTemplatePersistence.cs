using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentTemplatePersistence
    {
        Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates();
        Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates(int year);
        Task<AssessmentTemplateModel> GetAssessmentTemplate(int id);
        Task<AssessmentTemplateTypeModel> GetAssessmentTemplateType(int id);
        Task<IReadOnlyCollection<AssessmentTemplatePermissionModel>> GetAssessmentTemplateByPermission(IReadOnlyCollection<int> permissionIds);
        Task<int> GetLatestVersionById(int assessmentTemplateId);
        Task<IReadOnlyCollection<AssessmentFormTypeModel>> GetAssessmentFormTypesAsync();
    }
}
