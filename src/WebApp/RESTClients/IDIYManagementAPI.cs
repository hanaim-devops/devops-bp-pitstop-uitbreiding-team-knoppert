namespace WebApp.RESTClients;

public interface IDIYManagementAPI
{
    [Get("/diy")]
    Task<List<DIYEvening>> GetDIYEvening();

    [Get("/diy/future")]
    Task<List<DIYEvening>> GetFutureDIYEvenings();

    [Post("/diy/registercustomer")]
    Task RegisterDIYEveningCustomer(RegisterDIYRegistration command);

    [Get("/diy/{id}/registrations")]
    Task<List<DIYRegistration>> GetRegistrationsForDIYEvening([AliasAs("id")] string diyEveningId);

    [Get("/diy/{id}")]
    Task<DIYEvening> GetDIYEveningById([AliasAs("id")] string diyEveningId);

    [Post("/diy")]
    Task RegisterDIYEvening(RegisterDIYEvening cmd);

    [Put("/diy/cancel/{id}")]
    Task CancelDIYEvening([AliasAs("id")] string diyEveningId);

    [Post("/diy/cancelregistration/{id}")]
    Task CancelRegistration([AliasAs("id")] string diyRegistrationId);
    
    [Post("/diy/registerfeedback")]
    Task RegisterDIYFeedback(RegisterDIYFeedback cmd);

    [Get("/diy/customerhistory/{customerName}")]
    Task<List<DIYCustomerHistory>> GetCustomerHistory(string customerName);

    [Get("/diy/getfeedback/{id}")]
    Task<List<DIYFeedback>> GetDIYFeedbackById([AliasAs("id")] string diyEveningId);
}