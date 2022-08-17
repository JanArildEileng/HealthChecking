
using MediatR;
using HealthChecking.BackEndApi.Application.Features.TestMediatR.Query;

namespace HealthChecking.BackEndApi.Application;

static public class AddServiceCollectionFeatures
{

    static public IServiceCollection AddMediatorServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(HelloMediatrHandler));
        return services;
    }

}
