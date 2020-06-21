using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSystem.ApiContract
{
    public class ErrorTypeInfo
    {
        public ErrorTypeInfo(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; }
        public string Message { get; }

        public ErrorDetail ToErrorDetail() => new ErrorDetail(this);

        public ErrorDetail ToErrorDetail(object data) => new ErrorDetail(this, data);
    }
}
