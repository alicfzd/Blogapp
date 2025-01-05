using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Exceptions.Common
{
    public class ExistsException<T> : Exception, IBaseException
    {
        public int Code => StatusCodes.Status409Conflict;

        public string ErrorMessage { get; }
        const string _message = "is exists";
        public ExistsException() : base(typeof(T).Name + _message)
        {
            ErrorMessage = typeof(T).Name + _message;
        }
        public ExistsException(string msg) : base(msg)
        {
            ErrorMessage = msg;
        }
    }
}
