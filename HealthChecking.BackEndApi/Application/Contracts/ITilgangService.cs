using HealthChecking.BackEndApi.Application.Models;

namespace HealthChecking.BackEndApi.Application.Contracts
{
    public interface ITilgangService
    {
        Task<IEnumerable<Tilganger>>  GetTilganger();
    }
}
