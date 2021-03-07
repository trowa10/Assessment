using Microsoft.EntityFrameworkCore;
using ProjectHRCommon.Constants;
using ProjectHRCommon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public class QuestionnaireDomPersistence : IQuestionnaireDomPersistence
    {

        private readonly DataContext _dataContext;

        public QuestionnaireDomPersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IReadOnlyCollection<DomModel>> GetByIds(IReadOnlyCollection<int> ids, int assessmetemplateId,
            string languageCode = Globals.DEFAULT_LANGUAGE_CODE)
        {
            var questionnaireIds = await _dataContext.TemplateQuestionnaires
                .Include(x => x.Questionnaire)
                .AsNoTracking()
                .Where(x => x.AssessmentTemplateId == assessmetemplateId)
                .Select(x => x.QuestionnaireId)
                .ToListAsync();

            var questionnaireDoms = await _dataContext.QuestionnaireDoms
                .Include(x => x.QuestionnaireDomTranslations)
                .ThenInclude(x => x.Translation)
                .AsNoTracking()
                .Where(x => questionnaireIds.Contains(x.QuestionnaireId) && ids.Contains(x.DomId))
                .Select(x => new
                {
                    DomId = x.DomId,
                    CategoryCode = x.Questionnaire.CategoryCode,
                    QuestionCode = x.Questionnaire.QuestionCode,
                    QuestionnaireId = x.QuestionnaireId,
                    QuestionnaireDomOrder = x.QuestionnaireDomOrder,
                    Translation = x.QuestionnaireDomTranslations
                        .Where(q => q.Translation.LanguageCode.ToLower() == languageCode.ToLower())
                        .Select(qq => qq.Translation.Text)
                        .FirstOrDefault()

                })
                .ToListAsync();

            var questionnaireDomTranslations = questionnaireDoms.Select(x => new
            {
                x.DomId,
                x.CategoryCode,
                x.QuestionCode,
                x.QuestionnaireId,
                x.QuestionnaireDomOrder,
                x.Translation
            });

            var questionnaireDomInfos = await _dataContext.Doms
                .AsNoTracking()
                .Where(x => x.ForAnswer)
                .Select(x => new
                {
                    x.DomId,
                    x.Style,
                    x.Id,
                    x.IsRequired,
                    x.PlaceHolder,
                    x.Value,
                    x.Group,
                    x.ForAnswer,
                    x.TableRow
                })
                .ToListAsync();


            return (from questionnaireDomTranslation in questionnaireDomTranslations
                    join questionnaireDomInfo in questionnaireDomInfos on
                         questionnaireDomTranslation.DomId equals questionnaireDomInfo.DomId
                    select new DomModel(
                        questionnaireDomInfo.DomId,
                        questionnaireDomInfo.Id,
                        questionnaireDomInfo.Style,
                        questionnaireDomInfo.Group,
                        questionnaireDomInfo.IsRequired,
                        questionnaireDomInfo.PlaceHolder,
                        questionnaireDomInfo.Value,
                        questionnaireDomInfo.ForAnswer,
                        questionnaireDomInfo.TableRow,
                        questionnaireDomTranslation.QuestionnaireDomOrder,
                        questionnaireDomTranslation.Translation
                    ))
               .ToList()
               .AsReadOnly();
        }
    }
}
