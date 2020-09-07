namespace RealEstateAgency.Models.Properties
{

    using Exceptions;
    using RealEstateAgency.Domain.Common;
    using static ModelConstants.Features;

    public class Features : ValueObject
    {
        internal Features(int floor)
        {
            this.Validate(floor);

            this.Floor = floor;
        }

        public int Floor { get; }


        private void Validate(int floor)
            => Guard.AgainstOutOfRange<InvalidFeaturesException>(
                floor,
                MinFloor,
                MaxFloor,
                nameof(this.Floor));
    }
}
