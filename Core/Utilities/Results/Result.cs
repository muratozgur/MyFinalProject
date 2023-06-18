using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)//if this constructor begins, automaticly other constructor begins too
        {
            //Message is readonly-we have only getter-. However, we can set readonly properties in constructors
            Message = message;
        }//Overloading

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
