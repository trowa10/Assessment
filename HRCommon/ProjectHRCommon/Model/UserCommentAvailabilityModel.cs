using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserCommentAvailabilityModel
    {
        private readonly string _categoryCode;
        private readonly bool _isAvailable;

        public UserCommentAvailabilityModel(bool isAvailable, string CategoryCode)
        {
            this._categoryCode = CategoryCode;
            this._isAvailable = isAvailable;
        }

        public bool IsAvailable => _isAvailable;

        public string CategoryCode => _categoryCode;
    }
}
