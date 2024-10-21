﻿
namespace WebApp.RESTClients;

public class DIYManagementAPI : IDIYManagementAPI
{
    private IDIYManagementAPI _restClient;

    public DIYManagementAPI(IConfiguration config, HttpClient httpClient)
    {
        string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("DIYManagementAPI");
        httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
        _restClient = RestService.For<IDIYManagementAPI>(
            httpClient,
            new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            });
    }

    public async Task<DIYEvening> GetDIYEveningById([AliasAs("id")] string diyEveningId)
    {
        return await _restClient.GetDIYEveningById(diyEveningId);
    }

    public async Task<List<DIYEvening>> GetDIYEvening()
    {
        return await _restClient.GetDIYEvening();
    }

    public async Task RegisterDIYEveningCustomer(RegisterDIYRegistration command)
    {
        await _restClient.RegisterDIYEveningCustomer(command);
    }

    public async Task RegisterDIYEvening(RegisterDIYEvening cmd)
    {
        await _restClient.RegisterDIYEvening(cmd);
    }

    public async Task RegisterDIYFeedback(RegisterDIYFeedback cmd)
    {
        await _restClient.RegisterDIYFeedback(cmd);
    }

    public async Task<List<DIYFeedback>> GetDIYFeedbackById([AliasAs("id")] string diyEveningId)
    {
        return await _restClient.GetDIYFeedbackById(diyEveningId);
    }

    public async Task<List<DIYRegistration>> GetDIYRegistrationById([AliasAs("id")] string diyEveningId)
    {
        return await _restClient.GetDIYRegistrationById(diyEveningId);
    }
}