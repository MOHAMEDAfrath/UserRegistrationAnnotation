using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationAnnotations
{
    public class CustomException:Exception
    {

        public enum ExceptionType
        {
            NO_SUCH_METHOD, NO_SUCH_CLASS, NO_CONSTRUCTOR_FOUND, NO_METHOD_FOUND, INVALID_MESSAGE, NO_FIELD_FOUND
        }
        ExceptionType exceptiontype;
        public CustomException(ExceptionType exception, string message) : base(message)
        {
            this.exceptiontype = exception;
        }
    }
}
