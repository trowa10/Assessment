using AssessmentPersistence;
using ProjectHRCommon.Constants;
using ProjectHRCommon.Enum;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentAnswerManager : IAssessmentAnswerManager
    {
        private readonly IAssessmentAnswersPersistence _assessmentAnswersPersistence;
        private readonly IAssessmentQuestionsPersistence _assessmentQuestionsPersistence;
        private readonly IAssessmentUserStatusPersistence _assessmentUserStatusPersistence;
        private readonly IQuestionnaireDomPersistence _questionnaireDomPersistence;

        public AssessmentAnswerManager(IAssessmentAnswersPersistence assessmentAnswersPersistence,
            IAssessmentQuestionsPersistence assessmentQuestionsPersistence,
            IAssessmentUserStatusPersistence assessmentUserStatusPersistence,
            IQuestionnaireDomPersistence questionnaireDomPersistence)
        {
            _assessmentAnswersPersistence = assessmentAnswersPersistence;
            _assessmentQuestionsPersistence = assessmentQuestionsPersistence;
            _assessmentUserStatusPersistence = assessmentUserStatusPersistence;
            _questionnaireDomPersistence = questionnaireDomPersistence;
        }

        public async Task<IReadOnlyCollection<AnswersModel>> GetAssessmentMigrateAnswers(int CurrentAssessmentUserStatusId, int DoneAssessmentUserStatusId)
        {

            List<QuesionaireDomInfoModel> crntQuesionaireDomInfo = new List<QuesionaireDomInfoModel>();
            List<QuesionaireDomInfoModel> dneQuesionaireDomInfo = new List<QuesionaireDomInfoModel>();
            List<QuestionTemplateModel> doneQuestionTemplateModels = new List<QuestionTemplateModel>();
            List<QuestionTemplateModel> currentQuestionTemplateModels = new List<QuestionTemplateModel>();
            List<AnswersModel> myAnswers = new List<AnswersModel>();

            var getCurrentAssessmentuserStatuTask = _assessmentUserStatusPersistence.GetByAssessmentUserStatus(CurrentAssessmentUserStatusId);
            var getDoneAssessmentuserStatusTask = _assessmentUserStatusPersistence.GetByAssessmentUserStatus(DoneAssessmentUserStatusId);

            await Task.WhenAll(getCurrentAssessmentuserStatuTask, getDoneAssessmentuserStatusTask);

            var currentAssessmentUserStatus = getCurrentAssessmentuserStatuTask.Result;
            var donetAssessmentUserStatus = getDoneAssessmentuserStatusTask.Result;

            if (donetAssessmentUserStatus.StatusId == (int)AssessmentState.Done)
            {
                var getCurrentQuestionnaire = await _assessmentQuestionsPersistence.GetTemplateQuestionnaire(currentAssessmentUserStatus.AssessmentTemplateId);
                var getDoneQuestionnaire = await _assessmentQuestionsPersistence.GetTemplateQuestionnaire(donetAssessmentUserStatus.AssessmentTemplateId);
                var getDoneAssessmentAnswer = await _assessmentAnswersPersistence.GetAnswers(DoneAssessmentUserStatusId);


                var getCurrentQuestionTemplates = getCurrentQuestionnaire.QuestionnaireModel
                    .Select(x => x.Questions)
                    .ToList();

                var getDoneQuestionnairesTemplates = getDoneQuestionnaire.QuestionnaireModel
                    .Select(x => x.Questions)
                    .ToList();


                foreach (var currentQuestionnaireModels in getCurrentQuestionTemplates)
                    currentQuestionTemplateModels.AddRange(currentQuestionnaireModels);

                foreach (var doneQuestionnaireModels in getDoneQuestionnairesTemplates)
                    doneQuestionTemplateModels.AddRange(doneQuestionnaireModels);

                //(x.Value == null || x.Value == string.Empty) ? -1 : int.Parse(x.Value)
                var comparedAnswers = (from current in currentQuestionTemplateModels
                                       join done in doneQuestionTemplateModels on current.CategoryCode equals done.CategoryCode
                                       where current.QuestionCode == done.QuestionCode
                                       select new
                                       {
                                           DoneDomInfos = done.DomList
                                                          .Where(x => x.ForAnswer)
                                                          .OrderBy(x => x.Order)
                                                          .Select(x => new QuesionaireDomInfoModel(
                                                               x.DomId,
                                                               done.CategoryCode,
                                                               done.QuestionCode,
                                                               x.Value,
                                                               x.Style,
                                                               x.Order,
                                                               x.IsRequired,
                                                               x.ElementName))
                                                          .ToList(),

                                           CurrentDomInfos = current.DomList
                                                          .Where(x => x.ForAnswer)
                                                          .OrderBy(x => x.Order)
                                                          .Select(x => new QuesionaireDomInfoModel(
                                                               x.DomId,
                                                               current.CategoryCode,
                                                               current.QuestionCode,
                                                               x.Value,
                                                               x.Style,
                                                               x.Order,
                                                               x.IsRequired,
                                                               x.ElementName))
                                                          .ToList()
                                       }).ToList();



                foreach (var comparedAnswer in comparedAnswers)
                {
                    if (comparedAnswer.CurrentDomInfos.Count > 0)
                        foreach (var CurrentDomInfo in comparedAnswer.CurrentDomInfos)
                            crntQuesionaireDomInfo.Add(CurrentDomInfo);

                    if (comparedAnswer.DoneDomInfos.Count > 0)
                        foreach (var doneFormAnswer in comparedAnswer.DoneDomInfos)
                            dneQuesionaireDomInfo.Add(doneFormAnswer);
                }

                var matchingQuestionnaires = (from current in crntQuesionaireDomInfo
                                              join done in dneQuesionaireDomInfo on current.CategoryCode equals done.CategoryCode
                                              where current.QuestionCode == done.QuestionCode && current.Style == done.Style
                                              select new
                                              {
                                                  current.DomId,
                                                  current.CategoryCode,
                                                  current.QuestionCode,
                                                  current.Value,
                                                  current.Style,
                                                  current.Order,
                                                  current.IsRequired,
                                                  current.ElementName
                                              })
                                              .OrderBy(x => x.CategoryCode)
                                              .ThenBy(x => x.Order)
                                              .Distinct()
                                              .ToList()
                                              .AsReadOnly();

                var getQuestionnaireAnswerDominfo = await _questionnaireDomPersistence.GetByIds(getDoneAssessmentAnswer.AnswersModels.Select(x => x.DomId).ToList(), currentAssessmentUserStatus.AssessmentTemplateId);
                var matchingAnswerDoms = (from answer in getDoneAssessmentAnswer.AnswersModels
                                          join domInfo in getQuestionnaireAnswerDominfo on answer.DomId equals domInfo.DomId
                                          select new
                                          {
                                              answer.Id,
                                              answer.AnswerId,
                                              domInfo.DomId,
                                              answer.CategoryCode,
                                              answer.QuestionCode,
                                              answer.AnswerText,
                                              answer.Points,
                                              domInfo.Style,
                                              domInfo.Order,
                                              domInfo.IsRequired,
                                              domInfo.ElementName,
                                              domInfo.ForAnswer,
                                              domInfo.Group,
                                              domInfo.TableRow,
                                              domInfo.Text,
                                              domInfo.Value,

                                          })
                                              .OrderBy(x => x.CategoryCode)
                                              .ThenBy(x => x.Order)
                                              .Distinct()
                                              .ToList()
                                              .AsReadOnly();


                var myAnswerFortextArea = (from questionnaire in matchingQuestionnaires
                                           join answer in matchingAnswerDoms on questionnaire.CategoryCode equals answer.CategoryCode

                                           where questionnaire.QuestionCode == answer.QuestionCode && questionnaire.Style == answer.Style
                                                  && (Styles.text_area == questionnaire.Style || questionnaire.Style == Styles.text_note)
                                           select new AnswersModel(answer.Id, answer.AnswerId, questionnaire.DomId, questionnaire.CategoryCode,
                                                      questionnaire.QuestionCode, answer.AnswerText, answer.Points)
                         )
                         .Distinct()
                         .ToList()
                         .AsReadOnly();

                myAnswers.AddRange(myAnswerFortextArea);

                var myAnswerForRadio = (from questionnaire in matchingQuestionnaires
                                        join answer in matchingAnswerDoms on questionnaire.CategoryCode equals answer.CategoryCode

                                        where questionnaire.QuestionCode == answer.QuestionCode && questionnaire.Style == answer.Style
                                               && (Styles.choice_radio == questionnaire.Style || Styles.choice_radio_goal == questionnaire.Style)
                                               && int.Parse(questionnaire.Value) == answer.Points
                                        select new AnswersModel(answer.Id, answer.AnswerId, questionnaire.DomId, questionnaire.CategoryCode,
                                                      questionnaire.QuestionCode, answer.AnswerText, answer.Points)
                        )
                        .Distinct()
                        .ToList()
                        .AsReadOnly();

                myAnswers.AddRange(myAnswerForRadio);

                var actionPlanAnswers = matchingAnswerDoms.Where(x => x.Group == Groups.action_plan_answer && x.Style == Styles.text_cell).ToList();
                var actionPlanMatchingQuestionnaires = matchingQuestionnaires.Where(x => x.Style == Styles.text_cell).ToList();
                var myAnswerForActionPlan = (from answer in actionPlanAnswers
                                             join questionnaire in actionPlanMatchingQuestionnaires
                                               on answer.CategoryCode equals questionnaire.CategoryCode
                                             where answer.QuestionCode == questionnaire.QuestionCode && questionnaire.Style == answer.Style
                                                     && answer.Order == questionnaire.Order


                                             select new AnswersModel(answer.Id, answer.AnswerId, questionnaire.DomId, questionnaire.CategoryCode,
                                                  questionnaire.QuestionCode, answer.AnswerText, answer.Points)
                   )
                   .ToList()
                   .AsReadOnly();

                myAnswers.AddRange(myAnswerForActionPlan);


                return myAnswers
                .OrderBy(x => x.CategoryCode)
                .ThenBy(x => x.DomId).ToList();
            }

            return myAnswers;
        }
    }
}
