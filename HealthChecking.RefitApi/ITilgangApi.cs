using Refit;

namespace HealthChecking.RefitApi;
    public interface ITilgangApi
{
        [Get("/Tilgang")]
        Task<HttpResponseMessage> GetTilganger();

    }