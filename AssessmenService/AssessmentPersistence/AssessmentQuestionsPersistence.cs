using AssessmentPersistence.Entities.LookUpTables;
using Microsoft.EntityFrameworkCore;
using ProjectHRCommon;
using ProjectHRCommon.Constants;
using ProjectHRCommon.Model;
using ProjectHRCommon.Model.QuestionnaireModels;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AssessmentQuestionsPersistence : IAssessmentQuestionsPersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentQuestionsPersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<AssessmentQuestionsModel> GetAssessmentQuestions(int assessmentTemplateId, string languageCode = Globals.DEFAULT_LANGUAGE_CODE)
        {
            
            return await _dataContext.AssessmentQuestionnaires
                .Include(x => x.translationQuestionnaire)
                .Include(x=>x.translationQuestionnaire.Language)
                .Include(x => x.assessmentTemplate)
                .Where(x => x.AssessmentTemplateId == assessmentTemplateId && 
                            x.assessmentTemplate.IsActive == true && 
                            x.translationQuestionnaire.Language.Code == languageCode)
                .Select(x => new AssessmentQuestionsModel(
                    x.assessmentTemplate.Id,
                    x.assessmentTemplate.Title + " " + x.assessmentTemplate.Year,
                    x.translationQuestionnaire.QuestionsJson,
                    AssessmentHelper.IsAssessmentTemplateAvailable(x.assessmentTemplate.StartDate, x.assessmentTemplate.EndDate)
                    ))
                .FirstOrDefaultAsync();
        }

        private async Task<IReadOnlyCollection<CategoryTemplateModel>> GetAssessmentCategories(int assessmentTemplateId, string languageCode = Globals.DEFAULT_LANGUAGE_CODE)
        {
            var categories = await _dataContext.TemplateCategoryOrders
               .Include(x => x.AssessmentCategory)
                   .ThenInclude(x => x.CategoryDoms).ThenInclude(x => x.CategoryDomTranslations).ThenInclude(x => x.Translation)
               .Include(x => x.AssessmentCategory)
                   .ThenInclude(x => x.CategoryDoms).ThenInclude(x => x.Dom)
               .Where(x => x.AssessmentTemplateId == assessmentTemplateId)
               .OrderBy(x => x.CategoryOrder)
               .Select(x => new CategoryTemplateModel
               (
                    x.AssessmentCategory.CategoryCode,
                    x.CategoryOrder,
                    x.AssessmentCategory
                       .CategoryDoms
                           .Select(cd =>
                               new DomModel(
                                   cd.DomId,
                                   cd.Dom.Id,
                                   cd.Dom.Style,
                                   cd.Dom.Group,
                                   cd.Dom.IsRequired,
                                   cd.Dom.PlaceHolder,
                                   cd.Dom.Value,
                                   cd.Dom.ForAnswer,
                                   cd.Dom.TableRow,
                                   cd.CategoryDomOrder,
                                   cd.CategoryDomTranslations.Select(t => t.Translation)
                                       .Where(t => t.LanguageCode.ToString().ToLower() == languageCode.ToString().ToLower())
                                       .Select(t => t.Text)
                                       .FirstOrDefault()
                           )).ToArray()
               ))
               .ToListAsync();

            return categories;
        }

        private async Task<IReadOnlyCollection<QuestionTemplateModel>> GetAssessmentQuestionnaires(int assessmentTemplateId, string languageCode = Globals.DEFAULT_LANGUAGE_CODE)
        {
            var questions = await _dataContext.TemplateQuestionnaires
              .Include(q => q.Questionnaire)
                  .ThenInclude(qd => qd.QuestionnaireDoms)
                      .ThenInclude(qt => qt.QuestionnaireDomTranslations)
                          .ThenInclude(t => t.Translation)
              .Where(x => x.AssessmentTemplateId == assessmentTemplateId)
              .Select(x => new QuestionTemplateModel(
                  x.Questionnaire.CategoryCode,
                  x.Questionnaire.QuestionCode,
                  x.QuestionnaireOrder,
                  x.Questionnaire.QuestionnaireDoms
                      .Select(qd => new DomModel(
                          qd.DomId,
                          qd.Dom.Id,
                          qd.Dom.Style,
                          qd.Dom.Group,
                          qd.Dom.IsRequired,
                          qd.Dom.PlaceHolder,
                          qd.Dom.Value,
                          qd.Dom.ForAnswer,
                          qd.Dom.TableRow,
                          qd.QuestionnaireDomOrder,
                          qd.QuestionnaireDomTranslations.Select(t => t.Translation)
                              .Where(t => t.LanguageCode.ToString().ToLower() == languageCode.ToString().ToLower())
                              .Select(t => t.Text)
                              .FirstOrDefault()
                      )).ToArray()
                  )
              )
              .ToArrayAsync();

            return questions;
        }

        public async Task<AssessmentQuestionsModel> GetTemplateQuestionnaire(int assessmentTemplateId, string languageCode = Globals.DEFAULT_LANGUAGE_CODE)
        {

            var categories = await GetAssessmentCategories(assessmentTemplateId, languageCode);

            var categoryQuestions = await GetAssessmentQuestionnaires(assessmentTemplateId, languageCode);

            var questionnaire = categories
            .Select(x => new QuestionnaireTemplateModel(
                x,
                categoryQuestions.Where(q => q.CategoryCode == x.CategoryCode).ToArray()
            ))
            .ToArray();

            var template = await _dataContext.AssessmentTemplates
                .Where(x => x.Id == assessmentTemplateId)
                .FirstOrDefaultAsync();

            var AssessmentQuestionsModel = new AssessmentQuestionsModel(
                    template.Id,
                    template.Title + " " + template.Year,
                    questionnaire,
                    AssessmentHelper.IsAssessmentTemplateAvailable(template.StartDate, template.EndDate)
                );

            return AssessmentQuestionsModel;

        }
    }
}
