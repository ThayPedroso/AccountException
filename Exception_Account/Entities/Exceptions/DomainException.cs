using System;

namespace Exception_Account.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) 
            : base(message)
        {
        }
    }
}
