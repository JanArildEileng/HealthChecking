using HealthChecking.Shared.Models;
using Refit;

namespace HealthChecking.RefitApi;
public interface ILoggingApi
{
        [Get("/Logging")]
        Task<HttpResponseMessage> GetLogger();
        [Post("/Logging")]
        Task<HttpResponseMessage> PostLogg(LoggInnhold loggInnhold);


}