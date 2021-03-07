using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssistingManagerEmployeesModel<T>
    {
        private readonly DateTime _endDate;
        private readonly IReadOnlyCollection<T> _employees;

        public AssistingManagerEmployeesModel(DateTime endDate, IReadOnlyCollection<T> employees)
        {
            _endDate = endDate;
            _employees = employees;
        }

        public DateTime EndDate => _endDate;

        public IReadOnlyCollection<T> Employees => _employees;
    }
}
