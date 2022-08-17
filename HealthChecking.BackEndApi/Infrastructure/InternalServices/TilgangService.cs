using HealthChecking.BackEndApi.Application.Contracts;
using HealthChecking.BackEndApi.Application.Models;
using HealthChecking.RefitApi;
using Refit;

namespace HealthChecking.BackEndApi.Infrastructure.InteralServices;

public class TilgangService : ITilgangService
{
    private readonly ILogger<TilgangService> logger;
    private readonly ITilgangApi tilgangApi;

    public TilgangService(ILogger<TilgangService> logger,ITilgangApi tilgangApi )
    {
        this.logger = logger;
        this.tilgangApi = tilgangApi;
    }

    public async Task<IEnumerable<Tilganger>> GetTilganger()
    {

        try
        {
            var response = await tilgangApi.GetTilganger();
            if (response.IsSuccessStatusCode)
            {
                var tilganger = await response.Content.ReadFromJsonAsync<IEnumerable<Tilganger>>();
                return tilganger;
            }
            throw new Exception("GetTilganger failed " + response.ReasonPhrase);
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
}
