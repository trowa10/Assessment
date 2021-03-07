using ProjectHRCommon.DTO;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentAnswersPersistence
    {
        Task<AssessmentAnswersModel> GetAssessmentAnswers(int assessmentUserStatusId);
        Task<AssessmentAnswersModel> GetAnswers(int assessmentUserStatusId);
        Task<bool> InsertAnswer(AssessmentUserAnswerDTO assessmentAnswerDTO);
        Task<bool> UpdateAnswer(AssessmentUserAnswerDTO assessmentAnswerDTO);
        Task<bool> InsertAnswer_v2(AssessmentUserAnswerDTO assessmentAnswerDTO);
        Task<bool> UpdateAnswer_v2(AssessmentUserAnswerDTO assessmentAnswerDTO);
        Task<bool> IsAnswerIdExists(int assessmentUserStatusId);
        Task<bool> UpdateAssessmentAsnwerClearAnswer(AssessmentUserStatusModifyByDTO assessmentUserStatusModifyByDTO);
        Task<bool> UpdateAssessmentAsnwerClearAnswer(IReadOnlyCollection<AssessmentUserStatusModifyByDTO> assessmentUserStatusModifyByDTOs);
        Task<bool> DeleteAnswers(int[] answerIds);
    }
}
