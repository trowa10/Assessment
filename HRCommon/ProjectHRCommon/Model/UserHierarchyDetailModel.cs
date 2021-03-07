using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserHierarchyDetailModel
    {
        private readonly UserDetailModel _userTopLevel;
        private readonly IReadOnlyCollection<UserDetailModel> _usersLevel1; // reporting to topLevel
        private readonly IReadOnlyCollection<UserDetailModel> _usersLevel2; // reporting to level1
        private readonly IReadOnlyCollection<UserDetailModel> _others; // lvl3 users reporting to level2 

        public UserHierarchyDetailModel() { }

        public UserHierarchyDetailModel(UserDetailModel userTopLevel,
            IReadOnlyCollection<UserDetailModel> usersLevel1,
            IReadOnlyCollection<UserDetailModel> usersLevel2,
            IReadOnlyCollection<UserDetailModel> others)
        {
            _userTopLevel = userTopLevel;
            _usersLevel1 = usersLevel1;
            _usersLevel2 = usersLevel2;
            _others = others;
        }

        public UserDetailModel UserTopLevel => _userTopLevel;

        public IReadOnlyCollection<UserDetailModel> UsersLevel1 => _usersLevel1;

        public IReadOnlyCollection<UserDetailModel> UsersLevel2 => _usersLevel2;

        public IReadOnlyCollection<UserDetailModel> Others => _others;
    }
}
