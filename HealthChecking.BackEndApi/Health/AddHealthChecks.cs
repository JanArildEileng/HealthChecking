
namespace HealthChecking.BackEndApi.Health;

static public class AddHealthChecks
{

    static public IServiceCollection AddHealthAllChecks(this IServiceCollection services)
    {
        services.AddHealthChecks()
            .AddCheck<SampleHealthCheck>("Sample");
        return services;
    }

}
