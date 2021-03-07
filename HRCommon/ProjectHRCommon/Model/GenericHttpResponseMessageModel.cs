using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectHRCommon.Model
{
    [ExcludeFromCodeCoverage]
    public class GenericHttpResponseMessageModel
    {
        private readonly bool _isSuccess;

        private readonly string _errorCode;

        private readonly string _message;

        private readonly object _result;

        public GenericHttpResponseMessageModel(bool isSuccess, string errorCode, string message, object result)
        {
            _isSuccess = isSuccess;
            _errorCode = errorCode;
            _message = message;
            _result = result;
        }

        public GenericHttpResponseMessageModel(bool isSuccess, string errorCode, string message)
        {
            _isSuccess = isSuccess;
            _errorCode = errorCode;
            _message = message;
        }

        public bool IsSuccess => _isSuccess;

        public string ErrorCode => _errorCode;

        public string Message => _message;

        public object Result => _result;
    }
}
