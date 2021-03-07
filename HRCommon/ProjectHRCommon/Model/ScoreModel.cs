namespace ProjectHRCommon.Model
{
    public class ScoreModel
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _min;
        private readonly int _max;
        private readonly int _scoreCriteriaId;

        public ScoreModel(int id, string name, int min, int max, int scoreCriteriaId)
        {
            _id = id;
            _name = name;
            _min = min;
            _max = max;
            _scoreCriteriaId = scoreCriteriaId;
        }

        public int Id => _id;

        public string Name => _name;

        public int Min => _min;

        public int Max => _max;

        public int ScoreCriteriaId => _scoreCriteriaId;
    }
}
