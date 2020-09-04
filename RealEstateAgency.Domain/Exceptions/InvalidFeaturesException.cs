namespace RealEstateAgency.Exceptions
{
    public class InvalidFeaturesException : BaseDomainException
    {
        public InvalidFeaturesException()
        {
        }

        public InvalidFeaturesException(string error) => this.Error = error;
    }
}
