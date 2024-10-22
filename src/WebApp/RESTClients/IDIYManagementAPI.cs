namespace WebApp.RESTClients;

public interface IDIYManagementAPI
{
    [Get("/diy")]
    Task<List<DIYEvening>> GetDIYEvening();

    [Post("/diy/registercustomer")]
    Task RegisterDIYAvondCustomer(RegisterDIYRegistration command);

    [Get("/diyavonden/{id}/registrations")]
    Task<List<DIYRegistration>> GetRegistrationsForDIYAvond([AliasAs("id")] string diyAvondId);

    [Get("/diy/{id}")]
    Task<DIYEvening> GetDIYEveningById([AliasAs("id")] string diyEveningId);

    [Post("/diy")]
    Task RegisterDIYEvening(RegisterDIYEvening cmd);
}