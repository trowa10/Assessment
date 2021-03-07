using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserAdminDetailModel
    {
        private readonly string _twwid;
        private readonly string _fullName;
        private readonly string _permission;
        private readonly string _siteLocation;       
        private readonly string _orgUnit;    
        private readonly string _reportTo;
        private readonly string _reportToName;
        private readonly bool _isActive;
        private readonly bool _isExclude;
        private readonly bool? _isAssisssted;

        public UserAdminDetailModel(string twwid, string fullName,string permission, string siteLocation, string orgUnit, string reportTo, string reportToName, bool isActive, bool isExclude, bool? isAssisssted)
        {
            _twwid = twwid;
            _fullName = fullName;
            _permission = permission;
            _siteLocation = siteLocation;
            _orgUnit = orgUnit;
            _reportTo = reportTo;
            _reportToName = reportToName;
            _isActive = isActive;
            _isExclude = isExclude;
            _isAssisssted = isAssisssted;          
        }

        public string Twwid => _twwid;

        public string FullName => _fullName;

        public string SiteLocation => _siteLocation;

        public string OrgUnit => _orgUnit;

        public string ReportTo => _reportTo;

        public string ReportToName => _reportToName;

        public bool IsActive => _isActive;

        public bool IsExclude => _isExclude;

        public bool? IsAssisssted => _isAssisssted;

        public string Permission => _permission;
    }
}
