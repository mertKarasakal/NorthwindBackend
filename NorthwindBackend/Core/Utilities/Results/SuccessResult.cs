using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //ıssuccess değeri default olarak true yapıldı
        public SuccessResult(string message) : base(true, message)
        {

        }

        //mesajsız
        public SuccessResult() : base(true)
        {

        }
    }
}
