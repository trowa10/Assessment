using ProjectHRCommon.Enum;

namespace ProjectHRCommon.Model
{
    public class TemplateScoreCriteriaModel
    {
        private readonly int _id;
        private readonly ScoreCriteria _scoreCriteriaId;

        public TemplateScoreCriteriaModel(int id, ScoreCriteria scoreCriteriaId)
        {
            _id = id;
            _scoreCriteriaId = scoreCriteriaId;
        }

        public int Id => _id;

        public ScoreCriteria ScoreCriteriaId => _scoreCriteriaId;
    }
}
