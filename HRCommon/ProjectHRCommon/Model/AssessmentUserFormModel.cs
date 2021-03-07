using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserFormModel
    {
        private readonly int _assessmentUserStatusId;
        private readonly string _formType;
        private readonly int _doneBy;
        private readonly DateTime? _dateDone;
        private readonly int _statusId;
        private readonly string _status;
        private readonly int _lockedToUserId;
        private readonly int _year;
        private readonly int _typeId;
        private readonly bool _isManagerForm;

        public AssessmentUserFormModel(int assessmentUserStatusId, string formType, int doneBy, DateTime? dateDone, int statusId, string status, int lockedToUserId, int year, int typeId, bool isManagerForm)
        {
            _assessmentUserStatusId = assessmentUserStatusId;
            _formType = formType;
            _doneBy = doneBy;
            _dateDone = dateDone;
            _statusId = statusId;
            _status = status;
            _lockedToUserId = lockedToUserId;
            _year = year;
            _typeId = typeId;
            _isManagerForm = isManagerForm;
        }

        public int AssessmentUserStatusId => _assessmentUserStatusId;

        public string FormType => _formType;

        public int DoneBy => _doneBy;

        public DateTime? DateDone => _dateDone;

        public int StatusId => _statusId;

        public string Status => _status;

        public int LockedToUserId => _lockedToUserId;

        public int Year => _year;

        public int TypeId => _typeId;

        public bool IsManagerForm => _isManagerForm;
    }
}
