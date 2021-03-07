using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentFormTypeModel
    {
        private readonly int _id;
        private readonly string _name;
        private readonly bool _isLatest;

        public AssessmentFormTypeModel(int id, string name, bool isLatest)
        {
            _id = id;
            _name = name;
            _isLatest = isLatest;
        }

        public int Id => _id;

        public string Name => _name;

        public bool IsLatest => _isLatest;
    }
}
