using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> :Result, IDataResult<T>
    {
        //sadece data gönderilebilir veya data,succes ve message gönderilebilir
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        //mesajsız data ve bool gönderilebilir
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
