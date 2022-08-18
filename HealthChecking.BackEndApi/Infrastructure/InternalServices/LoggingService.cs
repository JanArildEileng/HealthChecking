using HealthChecking.BackEndApi.Application.Contracts;
using HealthChecking.RefitApi;
using HealthChecking.Shared.Models;
using Refit;

namespace HealthChecking.BackEndApi.Infrastructure.InteralServices;

public class LoggingService:ILoggingService
{
    private readonly ILogger<LoggingService> logger;
    private readonly ILoggingApi loggingApi;

    public LoggingService(ILogger<LoggingService> logger, ILoggingApi loggingApi )
    {
        this.logger = logger;
        this.loggingApi = loggingApi;
    }

    public async Task<IEnumerable<LoggInnhold>> GetLogger()
    {

        try
        {
            var response = await loggingApi.GetLogger();
            if (response.IsSuccessStatusCode)
            {
                var loggInholdListe = await response.Content.ReadFromJsonAsync<IEnumerable<LoggInnhold>>();
                return loggInholdListe;
            }
            throw new Exception("GetLogger failed " + response.ReasonPhrase);
        }
        catch (ApiException apiException)
        {
            logger.LogError(" ApiException {Message} ", apiException.Message);

            throw;
        }
        catch (Exception exp)
        {
            logger.LogError(" Exception {Message} ", exp.Message);
            throw;
        }

    }

    public async Task<bool> PostLogg(LoggInnhold loggInnhold)
    {
        try
        {
            var response = await loggingApi.PostLogg(loggInnhold);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            throw new Exception("GetLogger failed " + response.ReasonPhrase);
        }
        catch (ApiException apiException)
        {
            logger.LogError(" ApiException {Message} ", apiException.Message);

            throw;
        }
        catch (Exception exp)
        {
            logger.LogError(" Exception {Message} ", exp.Message);
            throw;
        };
    }
}
