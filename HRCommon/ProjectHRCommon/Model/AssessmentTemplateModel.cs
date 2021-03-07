using ProjectHRCommon.Enum;

namespace ProjectHRCommon.Model
{
    public class AssessmentTemplateModel
    {
        private readonly int _id;
        private readonly int _year;
        private readonly string _title;
        private readonly string _version;
        private readonly bool _isAvailable;
        private readonly ScoreCriteria _scoreCriteria;
        private readonly int _typeId;
        private readonly bool _isStash;

        public AssessmentTemplateModel(int id, int year, string title, string version, bool isAvailable, ScoreCriteria scoreCriteria, int typeId, bool isStash)
        {
            _id = id;
            _year = year;
            _title = title;
            _version = version;
            _isAvailable = isAvailable;
            _scoreCriteria = scoreCriteria;
            _typeId = typeId;
            _isStash = isStash;
        }

        public int Id => _id;

        public int Year => _year;

        public string Title => _title;

        public string Version => _version;

        public bool IsAvailable => _isAvailable;

        public ScoreCriteria ScoreCriteriaId => _scoreCriteria;

        public int TypeId => _typeId;

        public bool IsStash => _isStash;
    }
}
