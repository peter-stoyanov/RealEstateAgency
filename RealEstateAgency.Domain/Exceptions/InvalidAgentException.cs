namespace RealEstateAgency.Exceptions
{
    public class InvalidAgentException : BaseDomainException
    {
        public InvalidAgentException()
        {
        }

        public InvalidAgentException(string error) => this.Error = error;
    }
}
