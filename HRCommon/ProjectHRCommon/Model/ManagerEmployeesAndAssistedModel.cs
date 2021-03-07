using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class ManagerEmployeesAndAssistedModel<T>
    {
        private readonly string _managerTwwid;
        private readonly string _managerName;
        private readonly IReadOnlyCollection<T> _employees;

        public ManagerEmployeesAndAssistedModel(string managerTwwid, string managerName, IReadOnlyCollection<T> employees)
        {
            _managerTwwid = managerTwwid;
            _managerName = managerName;
            _employees = employees;
        }

        public string ManagerTwwid => _managerTwwid;

        public string ManagerName => _managerName;

        public IReadOnlyCollection<T> Employees => _employees;
    }
}
