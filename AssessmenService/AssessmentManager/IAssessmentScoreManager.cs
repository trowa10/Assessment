using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public interface IAssessmentScoreManager
    {
        Task<IEnumerable<ScoreModel>> GetScores();
    }
}
