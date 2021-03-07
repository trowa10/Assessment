
using System;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class UserCommentsModel
    {
        private readonly int _id;
        private readonly int _twwid;
        private readonly int _parentId;
        private readonly bool _isEdited;
        private readonly DateTime _createdDateTime;
        private readonly DateTime _modifiedDateTime;
        private readonly string _comments;

        public UserCommentsModel(int id, int twwid, int parentId, bool isEdited, DateTime createdDateTime, DateTime modifiedDateTime, string comments)
        {
            this._id = id;
            this._twwid = twwid;
            this._parentId = parentId;
            this._isEdited = isEdited;
            this._createdDateTime = createdDateTime;
            this._modifiedDateTime = modifiedDateTime;
            this._comments = comments;
        }

        public int Id => this._id;

        public int Twwid => this._twwid;

        public int ParentId => this._parentId;

        public bool IsEdited => this._isEdited;

        public DateTime CreatedDateTime => this._createdDateTime;

        public DateTime ModifiedDateTime => this._modifiedDateTime;

        public string Comments => this._comments;
    }
}
