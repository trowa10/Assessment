using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentAnswersModel
    {
        private readonly int _assessmentUserStatusId;
        private readonly int _totalScore;
        private readonly string _answersJson;
        private readonly IReadOnlyCollection<AnswersModel> _answersModels;
        private readonly DateTime? _dateManagerApproved;
        private readonly DateTime? _dateEmployeeApproved;
        private readonly string _languageCode;
        private readonly int _approverTwwId;
        private readonly DateTime? _dateTimeSubmitted;

        //v2
        public AssessmentAnswersModel(int assessmentUserStatusId, int totalScore, DateTime? dateManagerApproved,
            DateTime? dateEmployeeApproved, string languageCode, int approverTwwId, DateTime? dateTimeSubmitted, IReadOnlyCollection<AnswersModel> answersModels)
        {
            _assessmentUserStatusId = assessmentUserStatusId;
            _totalScore = totalScore;
            _dateManagerApproved = dateManagerApproved;
            _dateEmployeeApproved = dateEmployeeApproved;
            _languageCode = languageCode;
            _approverTwwId = approverTwwId;
            _dateTimeSubmitted = dateTimeSubmitted;
            _answersModels = answersModels;
        }


        //v1
        public AssessmentAnswersModel(int assessmentUserStatusId, int totalScore, string answersJson, DateTime? dateManagerApproved,
            DateTime? dateEmployeeApproved, string languageCode, int approverTwwId, DateTime? dateTimeSubmitted)
        {
            _assessmentUserStatusId = assessmentUserStatusId;
            _totalScore = totalScore;
            _answersJson = answersJson;
            _dateManagerApproved = dateManagerApproved;
            _dateEmployeeApproved = dateEmployeeApproved;
            _languageCode = languageCode;
            _approverTwwId = approverTwwId;
            _dateTimeSubmitted = dateTimeSubmitted;
        }

    
        public int AssessmentUserStatusId => _assessmentUserStatusId;

        public int TotalScore => _totalScore;

        public string AnswersJson => _answersJson;

        public DateTime? DateManagerApproved => _dateManagerApproved;

        public DateTime? DateEmployeeApproved => _dateEmployeeApproved;

        public string LanguageCode => _languageCode;

        public int ApproverTwwId => _approverTwwId;

        public DateTime? DateTimeSubmitted => _dateTimeSubmitted;

        public IReadOnlyCollection<AnswersModel> AnswersModels => _answersModels;
    }
}
