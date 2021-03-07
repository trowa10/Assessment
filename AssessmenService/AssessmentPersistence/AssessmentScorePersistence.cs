using Microsoft.EntityFrameworkCore;
using ProjectHRCommon.Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentPersistence
{
    [ExcludeFromCodeCoverage]
    public class AssessmentScorePersistence : IAssessmentScorePersistence
    {
        private readonly DataContext _dataContext;

        public AssessmentScorePersistence(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<ScoreModel>> GetAll()
        {
            return await _dataContext.AssessmentScore
                .Select(x => new ScoreModel(x.Id, x.Name, x.Min, x.Max, x.ScoreCriteriaId))
               .ToListAsync();
        }

        public async Task<int> CalculateEmployeeLevel(int totalScore, int scoreCriteriaId)
        {
            IEnumerable<ScoreModel> scores = await Get(scoreCriteriaId);
            int defaultScore = scores.OrderBy(x => x.Id).FirstOrDefault().Id;
            foreach (var score in scores)
            {
                if (totalScore >= score.Min && totalScore <= score.Max)
                    return score.Id;
            }

            return defaultScore;
        }

        public async Task<IEnumerable<ScoreModel>> Get(int scoreCriteriaId)
        {
            return await _dataContext.AssessmentScore
                .AsNoTracking()
                .Where(x => x.ScoreCriteriaId == scoreCriteriaId)
                .Select(x => new ScoreModel(x.Id, x.Name, x.Min, x.Max, x.ScoreCriteriaId))
                .ToListAsync();
        }
    }
}
