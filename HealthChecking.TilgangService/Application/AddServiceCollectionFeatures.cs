
using MediatR;
using HealthChecking.TilgangService.Application.Queries;

namespace HealthChecking.TilgangService.Application;

static public class AddServiceCollectionFeatures
{

    static public IServiceCollection AddMediatorServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(GetTilgangerHandler));
        return services;
    }

}
