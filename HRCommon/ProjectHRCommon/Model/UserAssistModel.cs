

using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserAssistModel
    {
        private readonly int _id;
        private readonly string _twwid;
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _actualTwwId;

        public UserAssistModel(int id, string twwid, string firstName, string middleName, string actualTwwid)
        {
            _id = id;
            _twwid = twwid;
            _firstName = firstName;
            _middleName = middleName;
            _actualTwwId = actualTwwid;
        }

        public int Id => _id;

        public string Twwid => _twwid;

        public string FirstName => _firstName;

        public string MiddleName => _middleName;

        public string ActualTwwId => _actualTwwId;
    }
}
