using Microsoft.AspNetCore.Authentication.JwtBearer;
using Keycloak.AuthServices.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

var builder = WebApplication.CreateBuilder(args);

// add cors 
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:8080", "https://localhost:8080")
        .AllowCredentials());
});

// Set up logging
builder.Host.UseSerilog((context, logContext) => 
    logContext
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.WithMachineName()
);

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

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = "oidc";
})
.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
{
    options.Authority = "http://localhost:8080/realms/pitstop-realm";
    options.Audience = "pitstop_client";
    options.RequireHttpsMetadata = false;
    options.Events = new JwtBearerEvents
    {
        OnAuthenticationFailed = context =>
        {
            Console.WriteLine($"JWT authentication failed: {context.Exception.Message}");
            return Task.CompletedTask;
        }
    };
})
.AddOpenIdConnect("oidc", options =>
{
    options.Authority = "http://localhost:8080/realms/pitstop-realm";
    options.ClientId = "pitstop_client";
    options.RequireHttpsMetadata = false;
    options.SaveTokens = true;
    options.ResponseType = "code";
    options.Scope.Add("openid");
    options.Scope.Add("profile");
    options.Scope.Add("email");
    options.GetClaimsFromUserInfoEndpoint = true;

    options.Events = new OpenIdConnectEvents
    {
        OnRemoteFailure = context =>
        {
            // Log detailed error
            Console.WriteLine($"OIDC Error: {context.Failure.Message}");
            context.HandleResponse();
            return Task.CompletedTask;
        },
        OnTokenResponseReceived = context =>
        {
            Console.WriteLine("Token Response Received.");
            return Task.CompletedTask;
        }
    };
});


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

app.UseAuthentication();
app.UseAuthorization();

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
