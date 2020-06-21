using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSystem.ApiContract
{
    public class OperationException : Exception
    {
        public OperationException(ErrorDetail error)
        {
            Error = error;
        }

        public ErrorDetail Error { get; }

        public override string ToString() => Error.Type.Message;
    }
}
