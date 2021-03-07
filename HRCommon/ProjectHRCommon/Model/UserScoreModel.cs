using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserScoreModel
    {     
        private readonly int _twwId;
        private readonly string _score;

        public UserScoreModel(int twwId, string score)
        {
            _twwId = twwId;
            _score = score;
        }     

        public int TwwId => _twwId;

        public string Result => _score;
    }
}
