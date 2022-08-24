using HealthChecking.TilgangService.Application.Notifications;
using MediatR;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecking.TilgangService.Health;

public class TestNotificationsHealthCheck1 : IHealthCheck,INotificationHandler<TestNotifications>
{
    static DateTime? lastCalled = null;
    static int counter = 0;

    static IDictionary<string, object> allCallDates = new Dictionary<string, object>()
    {
    };

    public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, CancellationToken cancellationToken = default)
    {

        IReadOnlyDictionary<string, object> data = (IReadOnlyDictionary<string, object>)allCallDates;

        if (lastCalled.HasValue)
        {
            return Task.FromResult(
                HealthCheckResult.Healthy($"Last notifications received  at {lastCalled.Value}", data));
        }

        return Task.FromResult(
            HealthCheckResult.Degraded("No notifications received ", null, data));
    }

    public Task Handle(TestNotifications notification, CancellationToken cancellationToken)
    {
        lastCalled = DateTime.Now;
        allCallDates.Add((++counter).ToString(), lastCalled);

        return Task.CompletedTask;
    }


}
