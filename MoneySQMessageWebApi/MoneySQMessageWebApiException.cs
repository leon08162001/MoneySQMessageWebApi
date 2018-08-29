using System;
using System.Runtime.Serialization;

namespace WebApiAp
{
    public enum MoneySQMessageWebApiErrror
    {
        None,
        NoAnyRow,
        ObjectNotFound,
        SystemError,
        Other
    }
    public class MoneySQMessageWebApiException : Exception, ISerializable
    {
        protected MoneySQMessageWebApiErrror _ErrorCode = MoneySQMessageWebApiErrror.None;
        protected string _ErrorMessage;

        public MoneySQMessageWebApiErrror ErrorCode
        {
            get { return _ErrorCode; }
        }

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        public MoneySQMessageWebApiException()
            : base()
        {
            _ErrorMessage = Enum.GetName(typeof(MoneySQMessageWebApiErrror), _ErrorCode);
        }
        public MoneySQMessageWebApiException(MoneySQMessageWebApiErrror ErrorCode)
        {
            _ErrorCode = ErrorCode;
            _ErrorMessage = Enum.GetName(typeof(MoneySQMessageWebApiErrror), _ErrorCode);
        }
        public MoneySQMessageWebApiException(string message)
            : base(message)
        {
            _ErrorCode = MoneySQMessageWebApiErrror.Other;
            _ErrorMessage = message;
        }
        public MoneySQMessageWebApiException(string message, Exception inner)
            : base(message, inner)
        {
            _ErrorCode = MoneySQMessageWebApiErrror.Other;
            _ErrorMessage = message;

        }
        // This constructor is needed for serialization.
        protected MoneySQMessageWebApiException(SerializationInfo info, StreamingContext context)
                        : base(info, context)
        {

        }
    }
}