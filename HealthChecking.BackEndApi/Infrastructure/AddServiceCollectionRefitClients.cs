using HealthChecking.RefitApi;
using Refit;

namespace HealthChecking.BackEndApi.Application;

static public class AddServiceCollectionRefitClients
{

    static public IServiceCollection AddRefitClients(this IServiceCollection services)
    {

        services.AddRefitClient<ITilgangApi>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://localhost:7313/");
                });

        services.AddRefitClient<ILoggingApi>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://localhost:7156/");
                });



        return services;
    }

}
