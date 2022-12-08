using NewsletterSimpleDI.ApplicationService;
using NewsletterSimpleDI.DomainModel;
using NewsletterSimpleDI.ViewModel;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapPost("/subscription", (
    EmailViewModel emailViewModel, 
    SubscriptionService subscriptionService) =>
{
    subscriptionService.Register(emailViewModel.Email);
});
app.MapGet("/user", ()=>
{
    User user = null;
    return new UserViewModel{Name = user.Name};
});
app.Run();
