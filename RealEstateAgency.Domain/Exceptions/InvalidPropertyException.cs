namespace RealEstateAgency.Exceptions
{
    public class InvalidPropertyException : BaseDomainException
    {
        public InvalidPropertyException()
        {
        }

        public InvalidPropertyException(string error) => this.Error = error;
    }
}
