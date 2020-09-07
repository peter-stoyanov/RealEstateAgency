namespace RealEstateAgency.Exceptions
{
    public class InvalidVisitException : BaseDomainException
    {
        public InvalidVisitException()
        {
        }

        public InvalidVisitException(string error) => this.Error = error;
    }
}
