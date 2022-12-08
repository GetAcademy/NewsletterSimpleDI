using NewsletterSimpleDI.DomainModel;
using NewsletterSimpleDI.DomainServices;

namespace NewsletterSimpleDI.ApplicationService
{
    public class SubscriptionService
    {
        private ISubscritionRepository _subscriptionRepository;
        private IEmailService _emailService;

        public SubscriptionService(
            ISubscritionRepository subscriptionRepository,
            IEmailService emailService
            )
        {
            _emailService = emailService;
            _subscriptionRepository = subscriptionRepository;
        }

        public void Register(string emailAddress)
        {
            var subscription = new Subscription(emailAddress);
            var isSuccess = _subscriptionRepository.Save(subscription);
            if (!isSuccess) return;
            var email = new Email(
                emailAddress, 
                "myapp@mydomain.com", 
                "code", 
                subscription.VerificationCode.ToString());
            _emailService.Send(email);

            /*
             * - lage kode
             * - lagre epost + kode i databasen
             * - sender epost
             */
        }

        public void Verify()
        {

        }
    }
}
