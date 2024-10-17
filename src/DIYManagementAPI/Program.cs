using DIYManagementAPI.Controllers;
using DIYManagementAPI.Data;
using DIYManagementAPI.Services;
using DIYManagementAPI.Models;
using Serilog;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// setup logging
builder.Host.UseSerilog((context, logContext) =>
    logContext
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.WithMachineName()
);

// Add services to the container.

// Heeft met oneidigen loops door many to many reltaties te maken. zie ADR
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DiyTestModelService>();
builder.Services.AddScoped<DYIService>();
builder.Services.AddScoped<DYIDAO>();

var connectionString = builder.Configuration.GetConnectionString("DIYManagementCN");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    scope.ServiceProvider.GetService<DatabaseContext>().MigrateDB();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
