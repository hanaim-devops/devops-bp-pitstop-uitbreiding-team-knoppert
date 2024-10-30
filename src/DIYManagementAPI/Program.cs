using DIYManagementAPI.Controllers;
using DIYManagementAPI.Data;
using DIYManagementAPI.Services;
using DIYManagementAPI.Models;
using Serilog;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration; // Add this namespace if not already present

var builder = WebApplication.CreateBuilder(args);

// **Add this block to clear default configuration sources and re-add them without file watching**
builder.Configuration.Sources.Clear();

builder.Configuration
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: false)
    .AddEnvironmentVariables();

// setup logging
builder.Host.UseSerilog((context, logContext) =>
    logContext
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.WithMachineName()
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
