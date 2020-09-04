namespace RealEstateAgency.Models
{

    using Exceptions;
    using Domain.Common;

    public class Address : ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string street, string city, string state, string country, string zipcode)
        {
            this.Validate(street, city, state, country, zipcode);
            
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
        }
        
        private void Validate(string street, string city, string state, string country, string zipcode)
        {
            Guard.AgainstEmptyString<InvalidAddressException>(street, nameof(this.Street));
            Guard.AgainstEmptyString<InvalidAddressException>(city, nameof(this.City));
            Guard.AgainstEmptyString<InvalidAddressException>(state, nameof(this.State));
            Guard.AgainstEmptyString<InvalidAddressException>(country, nameof(this.Country));
            Guard.AgainstEmptyString<InvalidAddressException>(zipcode, nameof(this.ZipCode));
        }
    }
}
