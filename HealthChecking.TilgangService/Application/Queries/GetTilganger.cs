using MediatR;

using HealthChecking.TilgangService.Domain.Entities;
using HealthChecking.TilgangService.Domain.Repositories;

namespace HealthChecking.TilgangService.Application.Queries;

public class GetTilganger : IRequest<IEnumerable<Tilganger>> { }

public class GetTilgangerHandler : IRequestHandler<GetTilganger, IEnumerable<Tilganger>>
{
    private readonly ITilgangRespository tilgangRespository;

    public GetTilgangerHandler(ITilgangRespository tilgangRespository)
    {
        this.tilgangRespository = tilgangRespository;
    }

   

    public Task<IEnumerable<Tilganger>> Handle(GetTilganger request, CancellationToken cancellationToken)
    {
        var tilganger = tilgangRespository.GetTilganger();

        return Task.FromResult(tilganger);
    }
}
