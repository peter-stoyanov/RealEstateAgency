namespace RealEstateAgency.Models
{
    using Domain.Common;

    public class PropertyType : Enumeration
    {
        public static readonly PropertyType Apartment = new PropertyType(1, nameof(Apartment));
        public static readonly PropertyType House = new PropertyType(2, nameof(House));
        
        public PropertyType(int value, string name) : base(value, name)
        {
        }
        
        private PropertyType(int value)
            : this(value, FromValue<PropertyType>(value).Name)
        {
        }
    }
}