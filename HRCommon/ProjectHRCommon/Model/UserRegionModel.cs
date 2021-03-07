using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserRegionModel
    {
        private readonly int _userId;
        private readonly int _regionId;
        private readonly string _regionName;

        public UserRegionModel(int userId, int regionId, string regionName)
        {
            _userId = userId;
            _regionId = regionId;
            _regionName = regionName;
        }

        public int UserId => _userId;

        public int RegionId => _regionId;

        public string RegionName => _regionName;
    }
}
