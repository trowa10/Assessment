using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserDetailModel
    {
        private readonly string _twwid;
        private readonly string _firstName;
        private readonly string _middleName;
        private readonly string _lastName;
        private readonly string _email;
        private readonly string _countryIso2Code;
        private readonly string _country;
        private readonly string _siteCode;
        private readonly string _site;
        private readonly string _siteLocation;
        private readonly string _role;
        private readonly string _orgUnit;
        private readonly string _department;
        private readonly string _reportTo;
        private readonly string _hireStartDate;
        private readonly string _jobFamily;
        private readonly bool _isActive;
        private readonly bool _isExclude;
        private readonly bool _isAssisted;
        private readonly string _managerName;

        public UserDetailModel(string twwid, string firstName, string middleName, string lastName, string email, string countryIso2Code, string country, string siteCode, string site, string siteLocation, string role, string orgUnit, string department, string reportTo, string hireStartDate, string jobFamily, bool isActive, bool isExclude, bool isAssisted, string managerName)
        {
            _twwid = twwid;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _email = email;
            _countryIso2Code = countryIso2Code;
            _country = country;
            _siteCode = siteCode;
            _site = site;
            _siteLocation = siteLocation;
            _role = role;
            _orgUnit = orgUnit;
            _department = department;
            _reportTo = reportTo;
            _hireStartDate = hireStartDate;
            _jobFamily = jobFamily;
            _isActive = isActive;
            _isExclude = isExclude;
            _isAssisted = isAssisted;
            _managerName = managerName;
        }

        public UserDetailModel(string twwid, string firstName, string middleName, string lastName, string email, string countryIso2Code, string country, string siteCode, string site, string siteLocation, string role, string orgUnit, string department, string reportTo, string hireStartDate, string jobFamily, bool isActive, bool isExclude)
        {
            _twwid = twwid;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _email = email;
            _countryIso2Code = countryIso2Code;
            _country = country;
            _siteCode = siteCode;
            _site = site;
            _siteLocation = siteLocation;
            _role = role;
            _orgUnit = orgUnit;
            _department = department;
            _reportTo = reportTo;
            _hireStartDate = hireStartDate;
            _jobFamily = jobFamily;
            _isActive = isActive;
            _isExclude = isExclude;
        }

        public string Twwid => _twwid;

        public string FirstName => _firstName;

        public string MiddleName => _middleName;

        public string LastName => _lastName;

        public string Email => _email;

        public string CountryIso2Code => _countryIso2Code;

        public string Country => _country;

        public string SiteCode => _siteCode;

        public string Site => _site;

        public string SiteLocation => _siteLocation;

        public string Role => _role;

        public string OrgUnit => _orgUnit;

        public string Department => _department;

        public string ReportTo => _reportTo;

        public string HireStartDate => _hireStartDate;

        public string JobFamily => _jobFamily;

        public bool IsActive => _isActive;

        public bool IsExclude => _isExclude;

        public bool IsAssisted => _isAssisted;

        public string ManagerName => _managerName;
    }
}
