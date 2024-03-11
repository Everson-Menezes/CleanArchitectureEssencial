using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Validation
{
    public class DomainExceptionValidation : System.Exception
    {
        public DomainExceptionValidation(string message) : base(message) { }
        public static void When(bool hasError, string error)
        {
            if(hasError)
                throw new DomainExceptionValidation(error);
        }
    }
}