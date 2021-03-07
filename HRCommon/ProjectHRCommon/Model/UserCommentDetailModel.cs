using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserCommentDetailModel
    {
        private readonly int _id;
        private readonly string _categoryCode;
        private readonly int _assessmentUserStatusId;
        private readonly int _twwId;
        private readonly int _parentId;
        private readonly bool _isEdited;
        private readonly DateTime _createdDateTime;
        private readonly DateTime _modifiedDateTime;
        private readonly string _comments;

        public UserCommentDetailModel(int id, string categoryCode, int assessmentUserStatusId, int twwId, int parentId, bool isEdited, DateTime createdDateTime, DateTime modifiedDateTime, string comments)
        {
            _id = id;
            _categoryCode = categoryCode;
            _assessmentUserStatusId = assessmentUserStatusId;
            _twwId = twwId;
            _parentId = parentId;
            _isEdited = isEdited;
            _createdDateTime = createdDateTime;
            _modifiedDateTime = modifiedDateTime;
            _comments = comments;
        }

        public int Id => _id;

        public string CategoryCode => _categoryCode;

        public int AssessmentUserStatusId => _assessmentUserStatusId;

        public int TwwId => _twwId;

        public int ParentId => _parentId;

        public bool IsEdited => _isEdited;

        public DateTime CreatedDateTime => _createdDateTime;

        public DateTime ModifiedDateTime => _modifiedDateTime;

        public string Comments => _comments;
    }
}
