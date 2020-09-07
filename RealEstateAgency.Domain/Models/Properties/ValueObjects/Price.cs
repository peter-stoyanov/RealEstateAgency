namespace RealEstateAgency.Models.Properties
{

    using Exceptions;
    using Domain.Common;

    public class Price : ValueObject
    {
        public string Currency { get; private set; }
        public decimal Amount { get; private set; }

        public Price(string currency, decimal amount)
        {
            this.Validate(currency, amount);
            
            this.Currency = currency;
            this.Amount = amount;
        }
        
        private void Validate(string currency, decimal amount)
        {
            Guard.AgainstOutOfRange<InvalidPriceException>(
                amount,
                ModelConstants.Price.MinAmount,
                ModelConstants.Price.MaxAmount,
                nameof(this.Amount));
            
            Guard.AgainstEmptyString<InvalidPriceException>(currency, nameof(this.Currency));
        }
    }
}
