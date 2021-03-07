using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserPermissionModel
    {
        private readonly int _id;
        private readonly int _userId;
        private readonly int _permissionId;
        private readonly string _permissionName;
        private readonly int _regionId;
        private readonly string _siteCode;
        private readonly bool _isAdmin;
        public UserPermissionModel(int id, int userId, int permissionId, int regionId, bool isAdmin, string permissionName, string siteCode)
        {
            _id = id;
            _userId = userId;
            _permissionId = permissionId;
            _regionId = regionId;
            _isAdmin = isAdmin;
            _permissionName = permissionName;
            _siteCode = siteCode;
        }

        public int Id => _id;

        public int UserId => _userId;

        public int PermissionId => _permissionId;

        public int RegionId => _regionId;

        public bool IsAdmin => _isAdmin;

        public string PermissionName => _permissionName;

        public string SiteCode => _siteCode;
    }
}
