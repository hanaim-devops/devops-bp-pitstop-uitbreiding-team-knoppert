namespace WebApp.RESTClients;

public interface IDIYManagementAPI
{
    [Get("/diy")]
    Task<List<DIYAvond>> GetDIYAvonden();

    [Get("/diyavonden/{id}")]
    Task<DIYAvond> GetDIYAvondById([AliasAs("id")] string diyAvondId);

    [Post("/diy")]
    Task RegisterDIYAvond(RegisterDIYAvond command);

    [Get("/reperateur")]
    Task<List<Reparateur>> GetReparateursAsync();
}