using ProjectHRCommon.Model;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentQuestionsPersistence
    {
        Task<AssessmentQuestionsModel> GetAssessmentQuestions(int assessmentTemplateId, string languageCode = "en");

        Task<AssessmentQuestionsModel> GetTemplateQuestionnaire(int assessmentTemplateId, string languageCode = "en");
    }
}
