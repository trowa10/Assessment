using Microsoft.EntityFrameworkCore;
using ProjectHRCommon;
using ProjectHRCommon.Enum;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AssessmentTemplatePersistence : IAssessmentTemplatePersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentTemplatePersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates()
        {
            var result = await _dataContext.AssessmentTemplates
                .Where(x => x.IsActive == true && x.isStash == false)
                .ToListAsync();

            if (result != null)
            {
                return result.Select(x => new AssessmentTemplateModel(
                    x.Id,
                    x.Year,
                    x.Title,
                    x.Version,
                    AssessmentHelper.IsAssessmentTemplateAvailable(x.StartDate, x.EndDate),
                    (ScoreCriteria)x.ScoreCriteriaId,
                    x.TypeId,
                    x.isStash)

                )
                .AsEnumerable();
            }

            return null;

        }
        public async Task<IEnumerable<AssessmentTemplateModel>> GetAllAssessmentTemplates(int year)
        {

            var result = await _dataContext.AssessmentTemplates
                .Where(x => x.IsActive == true && x.isStash == false && x.Year == year)
                .ToListAsync();

            return result.Select(x => new AssessmentTemplateModel(
                   x.Id,
                   x.Year,
                   x.Title,
                   x.Version,
                   AssessmentHelper.IsAssessmentTemplateAvailable(x.StartDate, x.EndDate),
                    (ScoreCriteria)x.ScoreCriteriaId,
                    x.TypeId,
                    x.isStash)
               )
               .AsEnumerable();
        }

        public async Task<AssessmentTemplateModel> GetAssessmentTemplate(int id)
        {

            var result = await _dataContext.AssessmentTemplates

                .AsNoTracking()
                .Where(x => x.IsActive == true && x.Id == id)
                .FirstOrDefaultAsync();

            if (result == null)
                return null;

            return new AssessmentTemplateModel(
                   result.Id,
                   result.Year,
                   result.Title,
                   result.Version,
                   AssessmentHelper.IsAssessmentTemplateAvailable(result.StartDate, result.EndDate),
                   (ScoreCriteria)result.ScoreCriteriaId,
                   result.TypeId,
                    result.isStash);

        }

        public async Task<IReadOnlyCollection<AssessmentTemplatePermissionModel>> GetAssessmentTemplateByPermission(IReadOnlyCollection<int> permissionIds)
        {
            var result = await _dataContext.TemplatePermissions
                 .Include(x => x.AssessmentTemplate)
                 .AsNoTracking()
                 .Where(x => permissionIds.Contains(x.PermissionId))
                 .Select(x => new AssessmentTemplatePermissionModel(x.Id, x.AssessmentTemplateId, x.PermissionId, new AssessmentTemplateModel(
                         x.AssessmentTemplate.Id,
                     x.AssessmentTemplate.Year,
                     x.AssessmentTemplate.Title,
                     x.AssessmentTemplate.Version,
                     AssessmentHelper.IsAssessmentTemplateAvailable(x.AssessmentTemplate.StartDate, x.AssessmentTemplate.EndDate),
                     (ScoreCriteria)x.AssessmentTemplate.ScoreCriteriaId, x.AssessmentTemplate.TypeId,
                    x.AssessmentTemplate.isStash)))
                 .ToListAsync();

            return result.Where(x => x.AssessmentTemplateModel.IsAvailable == true).ToList();
        }

        public async Task<int> GetLatestVersionById(int assessmentTemplateId)
        {

            var latestVersion = await _dataContext.AssessmentTemplates
                .Include(x => x.Assessment)
                    .ThenInclude(x => x.AssessmentTemplates)
                .AsNoTracking()
                .Where(x => x.IsActive == true && x.Id == assessmentTemplateId)
                .Select(x => x.Assessment.AssessmentTemplates.Where(y => y.IsActive == true).OrderByDescending(o => float.Parse(o.Version)).Select(a => a.Id).FirstOrDefault())
                .FirstOrDefaultAsync();

            return latestVersion;

        }

        public async Task<IReadOnlyCollection<AssessmentFormTypeModel>> GetAssessmentFormTypesAsync()
        {
            var AssessmentTemplatesList = await _dataContext.AssessmentTemplates
                .Include(x => x.AssessmentFormType)
                .Where(x => x.IsActive == true && (AssessmentHelper.IsAssessmentTemplateAvailable(x.StartDate, x.EndDate)))
                .OrderByDescending(x => x.Year)
                            .ThenByDescending(x => x.StartDate)
                                .ThenByDescending(x => double.Parse(x.Version))
                .FirstOrDefaultAsync();

            var AssessmentFormTypesList = await _dataContext.AssessmentFormTypes
                .ToListAsync();

            var listOfAssessmentFormTypes = new List<AssessmentFormTypeModel>();
            foreach (var type in AssessmentFormTypesList)
            {
                bool isLatest = false;
                if (type.Id == AssessmentTemplatesList.TypeId)
                    isLatest = true;

                listOfAssessmentFormTypes.Add(new AssessmentFormTypeModel(type.Id, type.Name, isLatest));
            }

            return listOfAssessmentFormTypes;
        }

        public async Task<AssessmentTemplateTypeModel> GetAssessmentTemplateType(int id)
        {
            return await _dataContext.AssessmentTemplates
                 .AsNoTracking()
                 .Where(x => x.IsActive == true && x.Id == id)
                 .Select(x => new AssessmentTemplateTypeModel(x.Id, x.TypeId, EnumHelper.GetEnumDescription((AssessmentTemplateType)int.Parse(x.TypeId.ToString()))))
                 .FirstOrDefaultAsync();
        }
    }
}
