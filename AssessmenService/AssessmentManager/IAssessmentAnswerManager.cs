using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentAnswerManager
    {
        Task<IReadOnlyCollection<AnswersModel>> GetAssessmentMigrateAnswers(int CurrentAssessmentUserStatusId, int DoneAssessmentUserStatusId);
    }
}
