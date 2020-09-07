namespace RealEstateAgency.Domain.Models.Properties
{
    using Common;
    using RealEstateAgency.Exceptions;
    using RealEstateAgency.Models.Properties;
    using static RealEstateAgency.Models.ModelConstants.Property;

    internal class Property : Entity<int>
    {
        internal Property(
            string name,
            PropertyType propertyType,
            ServiceType serviceType,
            Price price,
            Features feaures,
            Address address)
        {
            this.Validate(name);

            this.Name = name;
            this.PropertyType = propertyType;
            this.ServiceType = serviceType;
            this.Price = price;
            this.Features = feaures;
            this.Address = address;
        }

        public string Name { get; private set; }

        public PropertyType PropertyType  { get; private set; }
        
        public ServiceType ServiceType { get; private set; }
        
        public Price Price { get; private set; }
        
        public Features Features { get; private set; }
        
        public Address Address { get; private set; }

        public Property UpdateName(string name)
        {
            this.Validate(name);
            this.Name = name;

            return this;
        }

        public Property UpdateType(PropertyType propertyType)
        {
            this.PropertyType = propertyType;

            return this;
        }

        public Property UpdateServiceType(ServiceType serviceType)
        {
            this.ServiceType = serviceType;

            return this;
        }

        public Property UpdateFeatures(Features features)
        {
            this.Features = features;

            return this;
        }

        public Property UpdateAddress(Address address)
        {
            this.Address = address;

            return this;
        }

        public Property UpdatePrice(Price price)
        {
            this.Price = price;

            return this;
        }

        private void Validate(string newName)
            => Guard.ForStringLength<InvalidPropertyException>(
                newName,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

    }
}
