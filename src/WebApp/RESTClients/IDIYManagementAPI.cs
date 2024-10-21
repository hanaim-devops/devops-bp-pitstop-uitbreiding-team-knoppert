﻿namespace WebApp.RESTClients;

public interface IDIYManagementAPI
{
    [Get("/diy")]
    Task<List<DIYEvening>> GetDIYEvening();

    [Post("/diy/registercustomer")]
    Task RegisterDIYEveningCustomer(RegisterDIYRegistration command);

    [Get("/diy/{id}")]
    Task<DIYEvening> GetDIYEveningById([AliasAs("id")] string diyEveningId);

    [Post("/diy")]
    Task RegisterDIYEvening(RegisterDIYEvening cmd);

    [Post("/diy/registerfeedback")]
    Task RegisterDIYFeedback(RegisterDIYFeedback cmd);

    [Get("/diy/getfeedback/{id}")]
    Task<List<DIYFeedback>> GetDIYFeedbackById([AliasAs("id")] string diyEveningId);

    [Get("/diy/getregistration/{id}")]
    Task<List<DIYRegistration>> GetDIYRegistrationById([AliasAs("id")] string diyEveningId);
}