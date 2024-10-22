using DIYManagementAPI.Controllers;
using DIYManagementAPI.Data;
using DIYManagementAPI.Services;
using DIYManagementAPI.Models;
using Serilog;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// setup logging
builder.Host.UseSerilog((context, logContext) =>
    logContext
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.WithMachineName()
);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DYIService>();
builder.Services.AddScoped<DYIDAO>();

var connectionString = builder.Configuration.GetConnectionString("DIYManagementCN");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure Prometheus metrics
app.UseMetricServer(); // Dit stelt de /metrics endpoint beschikbaar voor Prometheus
app.UseHttpMetrics();  // Deze middleware verzamelt automatisch HTTP-metrics

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