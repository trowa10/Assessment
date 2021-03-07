using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusLockPinModel
    {
        private readonly int _assessmentUserStatusId;
        private readonly int _lockTwwId;
        private readonly string _pin;
            

        public AssessmentUserStatusLockPinModel(int assessmentUserStatusId, int lockTwwId, string pin)
        {
            _assessmentUserStatusId = assessmentUserStatusId;
            _lockTwwId = lockTwwId;
            _pin = pin;
        }

        public int AssessmentUserStatusId => _assessmentUserStatusId;

        public int LockTwwId => _lockTwwId;

        public string Pin => _pin;
    }
}
