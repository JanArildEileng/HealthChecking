using HealthChecking.TilgangService.Domain.Entities;
using HealthChecking.TilgangService.Domain.Repositories;

namespace HealthChecking.TilgangService.Infrastucture.Repositories;

public class TilgangRespository : ITilgangRespository
{
    public async Task<IList<Tilganger>> GetTilganger()
    {
        var tilganger = new List<Tilganger>() {
            new Tilganger() {Navn="Catman",Role="Admin"},
            new Tilganger() {Navn="Kaiman",Role="User" }
        };

        return  await Task.FromResult(tilganger);
      
    }
}
