using HealthChecking.RefitApi;
using Refit;

namespace HealthChecking.BackEndApi.Application;

static public class AddServiceCollectionRefitClients
{

    static public IServiceCollection AddRefitClients(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddRefitClient<ILoggingApi>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri($"https://localhost:{configuration["ServiceApi:LoggingApi:Port"]}/");
                });

        services.AddRefitClient<ITilgangApi>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri($"https://localhost:{configuration["ServiceApi:TilgangApi:Port"]}/");
                });

        return services;
    }

}
