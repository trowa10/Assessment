using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    public interface IAssessmentScorePersistence
    {
        Task<IEnumerable<ScoreModel>> GetAll();

        Task<IEnumerable<ScoreModel>> Get(int scoreCriteriaId);

        Task<int> CalculateEmployeeLevel(int totalScore, int scoreCriteriaId);
    }
}
