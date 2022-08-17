using HealthChecking.TilgangService.Domain.Entities;

namespace HealthChecking.TilgangService.Domain.Repositories
{
    public interface ITilgangRespository
    {
        IEnumerable<Tilganger> GetTilganger();
    }
}
