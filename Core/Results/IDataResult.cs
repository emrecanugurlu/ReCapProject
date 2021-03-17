using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results
{
    public interface IDataResult<T>
    {
        bool Success { get; }
        string Message { get; }
        T Data { get; }
    }
}
