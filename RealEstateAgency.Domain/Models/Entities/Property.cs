namespace RealEstateAgency.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common;
    using RealEstateAgency.Exceptions;
    using static RealEstateAgency.Models.ModelConstants.Common;

    internal class Property : Entity<int>
    {
        internal Property(string name)
        {
            this.Validate(name);

            this.Name = name;
        }

        public string Name { get; private set; }

        public Property UpdateName(string name)
        {
            this.Validate(name);
            this.Name = name;

            return this;
        }

        public void Validate(string newName)
            => Guard.ForStringLength<InvalidPropertyException>(
                newName,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

    }
}
