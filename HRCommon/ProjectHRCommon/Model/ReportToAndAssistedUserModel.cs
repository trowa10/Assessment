using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class ReportToAndAssistedUserModel
    {
        private readonly string _twwid;
        private readonly string _employeeName;
        private readonly string _role;
        private readonly string _group;
        private readonly string _managerTwwId;
        private readonly string _manager;
        private readonly bool _isExcluded;
        private readonly bool _isAssisted;
        private readonly string _hireDate;
        private readonly bool _isManagerForm;

        public ReportToAndAssistedUserModel(string twwid, string employeeName, string role, string group, string managerTwwId, string manager, bool isExcluded, bool isAssisted,
            string hireDate, bool isManagerForm)
        {
            _twwid = twwid;
            _employeeName = employeeName;
            _role = role;
            _group = group;
            _managerTwwId = managerTwwId;
            _manager = manager;
            _isExcluded = isExcluded;
            _isAssisted = isAssisted;
            _hireDate = hireDate;
            _isManagerForm = isManagerForm;
            
        }

        public ReportToAndAssistedUserModel(string twwid, bool isAssisted)
        {
            _twwid = twwid;
            _isAssisted = isAssisted;
        }

        public string Twwid => _twwid;

        public string EmployeeName => _employeeName;

        public string Role => _role;

        public string Group => _group;

        public string Manager => _manager;

        public bool IsExcluded => _isExcluded;

        public bool IsAssisted => _isAssisted;

        public string HireDate => _hireDate;

        public bool IsManagerForm => _isManagerForm;

        public string ManagerTwwId => _managerTwwId;
    }
}
