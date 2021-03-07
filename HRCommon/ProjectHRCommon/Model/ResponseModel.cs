using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class ResponseModel
    {
        public ResponseModel(string status, bool isSuccess, object data)
        {
            _status = status;
            _isSuccess = isSuccess;
            _data = data;
        }   

        private readonly string _status;
        private readonly bool _isSuccess;
        private readonly object _data;

        public string Status => _status;

        public bool IsSuccess => _isSuccess;

        public object Data => _data;
    }
}
