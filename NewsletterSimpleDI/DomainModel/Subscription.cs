namespace NewsletterSimpleDI.DomainModel
{
    public class Subscription
    {
        public string EmailAddress { get; }
        public Guid VerificationCode { get; }
        public bool IsVerified { get; }

        public Subscription(string emailAddress, bool isVerified = false, Guid? verificationCode = null)
        {
            EmailAddress = emailAddress;
            IsVerified = isVerified;
            VerificationCode = verificationCode ?? Guid.NewGuid();
        }
    }
}
