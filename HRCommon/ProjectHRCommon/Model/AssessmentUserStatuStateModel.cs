using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserStatusStateModel
    {
        private readonly int _id;
        private readonly int _statusId;
        private readonly string _status;
        private readonly int _employeeLevelId;
        private readonly string _employeeLevel;

        public AssessmentUserStatusStateModel(int id, int statusId, string status, int employeeLevelId, string employeeLevel)
        {
            _id = id;
            _statusId = statusId;
            _status = status;
            _employeeLevelId = employeeLevelId;
            _employeeLevel = employeeLevel;
        }

        public int Id => _id;  
        public int StatusId => _statusId;
        public string Status => _status;
        public int EmployeeLevelId => _employeeLevelId;
        public string EmployeeLevel => _employeeLevel;

     
    }
}
