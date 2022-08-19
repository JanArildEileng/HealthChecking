using HealthChecking.BackEndApi.Application;
using HealthChecking.BackEndApi.Health;
using HealthChecking.BackEndApi.Infrastructure;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatorServices();
builder.Services.AddInfrastructure();
builder.Services.AddRefitClients(builder.Configuration);


builder.Services.AddHealthAllChecks(builder.Configuration);

builder.Services
           .AddHealthChecksUI()
           .AddInMemoryStorage();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/healthz", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.UseRouting().UseEndpoints(config => config.MapHealthChecksUI());

app.Run();
