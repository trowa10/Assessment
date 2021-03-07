using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class ManagerEmployeeCountModel
    {
        private readonly string _twwid;
        private readonly string _managerName;
        private readonly int _totalEmployeeCount;

        public ManagerEmployeeCountModel(string twwid, string managerName, int totalEmployeeCount)
        {
            _twwid = twwid;
            _managerName = managerName;
            _totalEmployeeCount = totalEmployeeCount;
        }

        public string Twwid => _twwid;

        public string ManagerName => _managerName;

        public int TotalEmployeeCount => _totalEmployeeCount;
    }
}
