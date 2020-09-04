using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Models
{
    class ModelConstants
    {
        public class Common
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 20;
            public const int MinEmailLength = 3;
            public const int MaxEmailLength = 50;
            public const int MaxUrlLength = 2048;
            public const int Zero = 0;
        }

        public class PhoneNumber
        {
            public const int MinPhoneNumberLength = 5;
            public const int MaxPhoneNumberLength = 20;
            public const string PhoneNumberRegularExpression = @"\+[0-9]*";
        }

        public class Features
        {
            public const int MinFloor = 0;
            public const int MaxFloor = 100;
        }
        
        public class Price
        {
            public const decimal MinAmount = 0;
            public const decimal MaxAmount = decimal.MaxValue;
        }

    }
}
