using ProjectHRCommon.Constants;
using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentQuestionnaireManager
    {
        Task<AssessmentAnswersModel> GetAnswers(int assessmentUserStatusId);
        Task<AssessmentAnswersModel> GetAssessmentAnswers(int assessmentUserStatusId);
        Task<AssessmentQuestionsModel> GetQuestionnaireByTemplateId(int assessmentTemplateId);
        Task<AssessmentQuestionsModel> GetQuestionnaireByTemplateLanguage(AssessmentLanguageDTO assessmentLanguageDTO);
        Task<AssessmentQuestionnaireDetailModel> GetAssessmentQuestionnaireDetail(int assessmentUserStatusId, int userId, bool isNoLocked = false);       
        Task<ResponseModel> UpsertAnswers(AssessmentAnswerDTO assessmentAnswerDTO);
        Task<ResponseModel> UpsertAnswers_v2(AssessmentAnswerDTO assessmentAnswerDTO);
        Task<ResponseModel> AutoUpsertAnswers(AssessmentAnswerDTO assessmentAnswerDTO);
        Task<ResponseModel> AutoUpsertAnswers_v2(AssessmentAnswerDTO assessmentAnswerDTO);
        Task<TemplateScoreCriteriaModel> GeTemplateScoreCriteria(int assessmentTemplateId);
        Task<int> GetTemplateLatestVersion(int year);

        //For API Version 2
        Task<AssessmentQuestionsModel> GetTemplateQuestionnaireByTemplateId(int assessmentTemplateId, string languageCode);
        Task<AssessmentQuestionnaireDetailModel> GetAssessmentQuestionnaireDetail_v2(int assessmentUserStatusId, int userId, bool isNoLocked = false);
        


    }
}
