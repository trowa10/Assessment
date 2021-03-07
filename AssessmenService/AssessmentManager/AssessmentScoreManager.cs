using AssessmentPersistence;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class AssessmentScoreManager : IAssessmentScoreManager
    {
        private readonly IAssessmentScorePersistence _assessmentScorePersistence;
        public AssessmentScoreManager(IAssessmentScorePersistence assessmentScorePersistence)
        {
            this._assessmentScorePersistence = assessmentScorePersistence;
        }

        public async Task<IEnumerable<ScoreModel>> GetScores()
        {
            return await this._assessmentScorePersistence.GetAll();
        }

    }
}
