using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecking.BackEndApi.Health;

public class SampleHealthCheck1 : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, CancellationToken cancellationToken = default)
    {

        bool evenSeconds = DateTime.Now.Second % 2 == 0;

        IReadOnlyDictionary<string, object> data = new Dictionary<string, object>()
        {

              { "Date", DateTime.Now }

        };
        



        // ...

        if (evenSeconds)
        {
            return Task.FromResult(
                HealthCheckResult.Healthy("A healthy result. Seconds is even",data));
        }

        return Task.FromResult(
            new HealthCheckResult(
                context.Registration.FailureStatus, "An unhealthy result  Seconds is uneven.",null,data));
    }
}
