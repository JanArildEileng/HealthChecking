namespace HealthChecking.TilgangService.Health;

static public class AddHealthChecks
{

    static public IServiceCollection AddHealthAllChecks(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHealthChecks()
            .AddCheck<TestNotificationsHealthCheck1>("TestNotificationsHealthCheck1")
            .AddCheck<SampleHealthCheck2>("Sample-2");
        return services;
    }

}
