using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Exceptions
{
    public class InvalidPhoneNumberException : BaseDomainException
    {
        public InvalidPhoneNumberException()
        {
        }

        public InvalidPhoneNumberException(string error) => this.Error = error;
    }
}
