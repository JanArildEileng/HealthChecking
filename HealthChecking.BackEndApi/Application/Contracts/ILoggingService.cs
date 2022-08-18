using HealthChecking.Shared.Models;

namespace HealthChecking.BackEndApi.Application.Contracts
{
    public interface ILoggingService
    {
        public Task<IEnumerable<LoggInnhold>> GetLogger();
        public Task<bool> PostLogg(LoggInnhold loggInnhold);


    }
}
