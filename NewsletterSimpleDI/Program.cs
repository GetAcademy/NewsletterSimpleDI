using NewsletterSimpleDI.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapPost("/subscription", (EmailViewModel emailViewModel) =>
{
    return true;
});
app.Run();
