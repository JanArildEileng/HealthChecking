
using MediatR;
using HealthChecking.BackEndApi.Application.Features.TestMediatR.Query;
using HealthChecking.BackEndApi.Application.Contracts;
using HealthChecking.BackEndApi.Infrastructure.InteralServices;

namespace HealthChecking.BackEndApi.Application;

static public class AddServiceCollectionInfrastructure
{

    static public IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ILoggingService, LoggingService>();
        services.AddScoped<ITilgangService, TilgangService>();
        return services;
    }

}
