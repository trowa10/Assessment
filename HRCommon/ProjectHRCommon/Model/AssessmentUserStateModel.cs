using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStateModel
    {
        private readonly int _id;
        private readonly int _userId;
        private readonly int _assessmentTemplateId;
        private readonly int _reportsTo;
        private readonly int _userRegionId;
        private readonly int _statusId;
        private readonly string _status;
        private readonly int _employeeLevelId;
        private readonly string _employeeLevel;
        private readonly string _siteCode;
        private readonly bool _formChanged;
        private readonly int? _lockedToUserId;
        private readonly bool _isAvailable;
        private readonly int _totalScore;
        private readonly bool? _showEmpLevel;

        public AssessmentUserStateModel(int id, int userId, int assessmentTemplateId, 
            int reportsTo, int userRegionId, int statusId, string status, 
            int employeeLevelId, string employeeLevel, string siteCode,
            int totalScore, bool? showEmpLevel)
        {
            _id = id;
            _userId = userId;
            _assessmentTemplateId = assessmentTemplateId;
            _reportsTo = reportsTo;
            _userRegionId = userRegionId;
            _statusId = statusId;
            _status = status;
            _employeeLevelId = employeeLevelId;
            _employeeLevel = employeeLevel;
            _siteCode = siteCode;
            _totalScore = totalScore;
            _showEmpLevel = showEmpLevel;
        }

        public AssessmentUserStateModel(int id, int userId, int assessmentTemplateId, 
            int reportsTo, int userRegionId, int statusId, string status, int employeeLevelId, 
            string employeeLevel, string siteCode, bool formChanged, int? lockedToUserId,
            bool isAvailable, int totalScore, bool? showEmpLevel)
        {
            _id = id;
            _userId = userId;
            _assessmentTemplateId = assessmentTemplateId;
            _reportsTo = reportsTo;
            _userRegionId = userRegionId;
            _statusId = statusId;
            _status = status;
            _employeeLevelId = employeeLevelId;
            _employeeLevel = employeeLevel;
            _siteCode = siteCode;
            _formChanged = formChanged;
            _lockedToUserId = lockedToUserId;
            _isAvailable = isAvailable;
            _totalScore = totalScore;
            _showEmpLevel = showEmpLevel;
        }

        public int Id => _id;

        public int UserId => _userId;

        public int AssessmentTemplateId => _assessmentTemplateId;

        public int ReportsTo => _reportsTo;

        public int UserRegionId => _userRegionId;

        public int StatusId => _statusId;

        public string Status => _status;

        public int EmployeeLevelId => _employeeLevelId;

        public string EmployeeLevel => _employeeLevel;

        public string SiteCode => _siteCode;

        public bool FormChanged => _formChanged;

        public int? LockedToUserId => _lockedToUserId;

        public bool IsAvailable => _isAvailable;

        public int TotalScore => _totalScore;

        public bool? ShowEmpLevel => _showEmpLevel;
    }
}
