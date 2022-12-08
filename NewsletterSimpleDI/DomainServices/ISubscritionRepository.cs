using NewsletterSimpleDI.DomainModel;

namespace NewsletterSimpleDI.DomainServices
{
    public interface ISubscritionRepository
    {
        bool Save(Subscription subscrition);

        Subscription Load(string email);
    }
}
