using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentQuestionnaireDetailModel
    {
        private readonly AssessmentUserStateModel _assessmentUserStatus;
        private readonly AssessmentQuestionsModel _assessmentQuestions;
        private readonly AssessmentAnswersModel _assessmentAnswers;
        private readonly IEnumerable<ScoreModel> _scores;
        private readonly AssessmentTemplateTypeModel _assessmentTemplateType;
        private readonly IReadOnlyCollection<UserCommentAvailabilityModel> _userCommentAvailabilityModels;
        private readonly AssessmentLinkFormDetailModel _assessmentLinkFormDetail;

        public AssessmentQuestionnaireDetailModel(AssessmentUserStateModel assessmentUserStatus, 
            AssessmentQuestionsModel assessmentQuestions, AssessmentAnswersModel assessmentAnswers,
            IEnumerable<ScoreModel> scores, AssessmentTemplateTypeModel assessmentTemplateType,
            IReadOnlyCollection<UserCommentAvailabilityModel> userCommentAvailabilityModels,
            AssessmentLinkFormDetailModel assessmentLinkFormDetailModel)
        {
            _assessmentUserStatus = assessmentUserStatus;
            _assessmentQuestions = assessmentQuestions;
            _assessmentAnswers = assessmentAnswers;
            _scores = scores;
            _assessmentTemplateType = assessmentTemplateType;
            _userCommentAvailabilityModels = userCommentAvailabilityModels;
            _assessmentLinkFormDetail = assessmentLinkFormDetailModel;
        }

        public AssessmentUserStateModel AssessmentUserStatus => _assessmentUserStatus;

        public AssessmentQuestionsModel AssessmentQuestions => _assessmentQuestions;

        public AssessmentAnswersModel AssessmentAnswers => _assessmentAnswers;

        public IEnumerable<ScoreModel> Scores => _scores;

        public AssessmentTemplateTypeModel AssessmentTemplateType => _assessmentTemplateType;

        public IReadOnlyCollection<UserCommentAvailabilityModel> UserCommentAvailabilityModels => _userCommentAvailabilityModels;

        public AssessmentLinkFormDetailModel AssessmentLinkFormDetail => _assessmentLinkFormDetail;
    }
}
