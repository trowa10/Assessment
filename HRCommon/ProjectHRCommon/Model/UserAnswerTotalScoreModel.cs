using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserAnswerTotalScoreModel
    {
        private readonly int _id;
        private readonly int _assessmentUserStatusId;
        private readonly int _totalScore;
        private readonly bool? _showEmpLevel;

        public UserAnswerTotalScoreModel(int id, int assessmentUserStatusId, int totalScore, bool? showEmpLevel)
        {
            _id = id;
            _assessmentUserStatusId = assessmentUserStatusId;
            _totalScore = totalScore; 
             _showEmpLevel = showEmpLevel;
        }

        public int Id => _id;

        public int AssessmentUserStatusId => _assessmentUserStatusId;

        public int TotalScore => _totalScore;

        public bool? ShowEmpLevel => _showEmpLevel;
    }
}
