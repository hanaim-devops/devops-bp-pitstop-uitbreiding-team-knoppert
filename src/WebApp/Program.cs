using Keycloak.AuthServices.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Set up logging
builder.Host.UseSerilog((context, logContext) => 
    logContext
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.WithMachineName()
);

builder.Services.AddKeycloakWebApiAuthentication(builder.Configuration);

builder.Services.AddAuthorization();

// Add framework services
builder.Services
    .AddMvc(options => options.EnableEndpointRouting = false)
    .AddNewtonsoftJson();

// Add health checks
builder.Services.AddHealthChecks();

// Add custom services
builder.Services.AddHttpClient<ICustomerManagementAPI, CustomerManagementAPI>();
builder.Services.AddHttpClient<IVehicleManagementAPI, VehicleManagementAPI>();
builder.Services.AddHttpClient<IWorkshopManagementAPI, WorkshopManagementAPI>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseBrowserLink();
}
else
{
    app.UseHsts();
    app.UseExceptionHandler("/Home/Error");
}

app.UseMvc();
app.UseStaticFiles();

app.UseHealthChecks("/hc");

app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
