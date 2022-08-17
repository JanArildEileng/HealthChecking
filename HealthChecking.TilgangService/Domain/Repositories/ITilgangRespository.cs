using HealthChecking.TilgangService.Domain.Entities;

namespace HealthChecking.TilgangService.Domain.Repositories
{
    public interface ITilgangRespository
    {
        Task<IList<Tilganger>> GetTilganger();
    }
}
