using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserCommentsModel
    {
        private readonly UserCommentsModel _parentComment;
        private readonly IReadOnlyCollection<UserCommentsModel> _childComments;

        public AssessmentUserCommentsModel(UserCommentsModel parentComment, IReadOnlyCollection<UserCommentsModel> childComments)
        {
            this._parentComment = parentComment;
            this._childComments = childComments;
        }
        public UserCommentsModel ParentComment => this._parentComment;

        public IReadOnlyCollection<UserCommentsModel> ChildComments => this._childComments;

    }
}
