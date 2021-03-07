
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserManagerAssistModel
    {
        private IReadOnlyCollection<UserNameModel> _userNameModels;
        private readonly int _assistingManagerCount;

        public UserManagerAssistModel(IReadOnlyCollection<UserNameModel> userNameModels, int assistingManagerCount)
        {
            _userNameModels = userNameModels;
            _assistingManagerCount = assistingManagerCount;
        }

        public IReadOnlyCollection<UserNameModel> UserNameModels => _userNameModels;

  

        public int AssistingManagerCount => _assistingManagerCount;
    }
}
