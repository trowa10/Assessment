using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserCompletedFormModel
    {
        private readonly int _assessmentUserStatusId;
        private readonly string _title;
        private readonly int _approverTwwId;
        private readonly DateTime? _dateTimeSubmitted;
        private readonly DateTime? _dateManagerApproved;
        private readonly int _year;

        public AssessmentUserCompletedFormModel(int assessmentUserStatusId, string title, int approverTwwId, DateTime? dateTimeSubmitted, DateTime? dateManagerApproved, int year)
        {
            _assessmentUserStatusId = assessmentUserStatusId;
            _title = title;
            _approverTwwId = approverTwwId;
            _dateTimeSubmitted = dateTimeSubmitted;
            _dateManagerApproved = dateManagerApproved;
            _year = year;
        }

        public int AssessmentUserStatusId => _assessmentUserStatusId;

        public string Title => _title;

        public int ApproverTwwId => _approverTwwId;

        public DateTime? DateTimeSubmitted => _dateTimeSubmitted;

        public DateTime? DateManagerApproved => _dateManagerApproved;

        public int Year => _year;
    }
}
