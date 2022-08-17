
using HealthChecking.TilgangService.Domain.Repositories;
using HealthChecking.TilgangService.Infrastucture.Repositories;
using MediatR;

namespace HealthChecking.TilgangService.Infrastucture;

static public class AddServiceCollectionInfrastructure
{

    static public IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped <ITilgangRespository,TilgangRespository>();
        return services;
    }

}
