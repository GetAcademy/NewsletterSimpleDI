using NewsletterSimpleDI.DomainModel;

namespace NewsletterSimpleDI.DomainServices
{
    public interface IEmailService
    {
        void Send(Email email);
    }
}
