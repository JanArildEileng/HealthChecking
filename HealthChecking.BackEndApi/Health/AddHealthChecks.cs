
namespace HealthChecking.BackEndApi.Health;

static public class AddHealthChecks
{

    static public IServiceCollection AddHealthAllChecks(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddHealthChecks()
            .AddUrlGroup(new Uri($"https://localhost:{configuration["ServiceApi:LoggingApi:Port"]}/swagger"),"LoggingService")
            .AddUrlGroup(new Uri($"https://localhost:{configuration["ServiceApi:TilgangApi:Port"]}/swagger"), "TilgangApiService")
            .AddCheck<SampleHealthCheck1>("Sample-1")
            .AddCheck<SampleHealthCheck2>("Sample-2");
        return services;
    }

}
