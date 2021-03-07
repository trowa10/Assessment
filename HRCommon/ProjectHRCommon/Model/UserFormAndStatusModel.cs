using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserFormAndStatusModel
    {
        private readonly string _twwid;
        private readonly int _statusId;
        private readonly int _assessmentId;
        private readonly bool _isManagerForm;
        private readonly int _lockedToUserid;
        private readonly string _reportsTo;
        private readonly AssessmentTemplateFormModel[] _formsList;

        public UserFormAndStatusModel(string twwid, int statusId, int assessmentId, bool isManagerForm, int lockedToUserid, string reportsTo, AssessmentTemplateFormModel[] formsList)
        {
            _twwid = twwid;
            _statusId = statusId;
            _assessmentId = assessmentId;
            _isManagerForm = isManagerForm;
            _lockedToUserid = lockedToUserid;
            _reportsTo = reportsTo;
            _formsList = formsList;
        }

        public string Twwid => _twwid;

        public int StatusId => _statusId;

        public int AssessmentId => _assessmentId;

        public bool IsManagerForm => _isManagerForm;

        public int LockedToUserid => _lockedToUserid;

        public string ReportsTo => _reportsTo;

        public AssessmentTemplateFormModel[] FormsList => _formsList;

        public class AssessmentTemplateFormModel
        {

            public int AssessmentUserStatusId { get; set; }
            public string TemplateTitle { get; set; }
            public int TemplateYear { get; set; }
            public bool IsManagerForm { get; set; }

        }
    }

  
}
