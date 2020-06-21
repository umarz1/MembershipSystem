using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSystem.ApiContract
{
    public class ErrorDetail
    {
        public ErrorDetail(ErrorTypeInfo type)
        {
            Type = type;
            HasData = false;
        }

        public ErrorDetail(ErrorTypeInfo type, object data)
        {
            Type = type;
            Data = data;
            HasData = true;
        }

        public ErrorTypeInfo Type { get; }
        public bool HasData { get; }
        public object Data { get; }
    }
}
