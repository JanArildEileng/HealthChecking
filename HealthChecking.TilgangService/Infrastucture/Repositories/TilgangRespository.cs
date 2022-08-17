using HealthChecking.TilgangService.Domain.Entities;
using HealthChecking.TilgangService.Domain.Repositories;

namespace HealthChecking.TilgangService.Infrastucture.Repositories;

public class TilgangRespository : ITilgangRespository
{
    public IEnumerable<Tilganger> GetTilganger()
    {
        var tilganger = new List<Tilganger>() {
            new Tilganger(),
            new Tilganger()
        };

        return tilganger;
      
    }
}
