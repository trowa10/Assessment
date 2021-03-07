using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class AssessmentUserCommentModel
    {
        private readonly int _id;
        private readonly int _parentId;
        private readonly bool _isEdited;
        private readonly DateTime _modifiedDateTime;

        public AssessmentUserCommentModel(int id, int parentId, bool isEdited, DateTime modifiedDateTime)
        {
            _id = id;
            _parentId = parentId;
            _isEdited = isEdited;
            _modifiedDateTime = modifiedDateTime;
        }

        public int Id => _id;

        public int ParentId => _parentId;

        public bool IsEdited => _isEdited;

        public DateTime ModifiedDateTime => _modifiedDateTime;
    }
}
