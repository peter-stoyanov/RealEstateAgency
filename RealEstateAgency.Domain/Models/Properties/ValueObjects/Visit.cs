namespace RealEstateAgency.Domain.Models.Properties
{
    using Common;
    using RealEstateAgency.Exceptions;
    using RealEstateAgency.Models;
    using RealEstateAgency.Models.Properties;
    using System;
    using static RealEstateAgency.Models.ModelConstants.Visit;

    // VO referencing entities ?
    internal class Visit : ValueObject
    {
        internal Visit(
            DateTime date,
            Agent agent,
            Client client,
            Property property)
        {
            this.Validate(date);

            this.Date = date;
            this.Property = property;
            this.Agent = agent;
            this.Client = client;
        }

        public DateTime Date { get; private set; }

        public Property Property { get; private set; }

        public Agent Agent { get; private set; }

        public Client Client { get; private set; }

        public Visit UpdateDate(DateTime date)
        {
            this.Validate(date);
            this.Date = date;

            return this;
        }

        private void Validate(DateTime date)
            => Guard.AgainstOutOfRange<InvalidVisitException>(
                date,
                MinDate,
                MaxDate,
                nameof(this.Date));

    }
}
