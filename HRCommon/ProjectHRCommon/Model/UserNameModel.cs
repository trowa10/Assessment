using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserNameModel
    {
        private readonly string _twwid;
        private readonly string _fullName;

        public UserNameModel(string twwid, string fullName)
        {
            _twwid = twwid;
            _fullName = fullName;
        }

        public string Twwid => _twwid;

        public string FullName => _fullName;
    }
}