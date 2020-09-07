namespace RealEstateAgency.Domain.Models.Properties
{
    using Common;
    using RealEstateAgency.Exceptions;
    using RealEstateAgency.Models.Properties;
    using static RealEstateAgency.Models.ModelConstants.Common;

    internal class Client : Entity<int>
    {
        internal Client(
            string name,
            PhoneNumber phoneNumber)
        {
            this.Validate(name);

            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public string Name { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

        public Client UpdateName(string name)
        {
            this.Validate(name);
            this.Name = name;

            return this;
        }

        public Client UpdatePhoneNumber(PhoneNumber phoneNumber)
        {
            this.PhoneNumber = phoneNumber;

            return this;
        }

        private void Validate(string newName)
            => Guard.ForStringLength<InvalidClientException>(
                newName,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

    }
}
