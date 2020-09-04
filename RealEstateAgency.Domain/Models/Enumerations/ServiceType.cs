namespace RealEstateAgency.Models
{
    using Domain.Common;

    public class ServiceType : Enumeration
    {
        public static readonly ServiceType Sell = new ServiceType(1, nameof(Sell));
        public static readonly ServiceType Rent = new ServiceType(2, nameof(Rent));
        
        public ServiceType(int value, string name) : base(value, name)
        {
        }
        
        private ServiceType(int value)
            : this(value, FromValue<ServiceType>(value).Name)
        {
        }
    }
}