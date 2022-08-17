using HealthChecking.BackEndApi.Application.Contracts;
using HealthChecking.Shared.Models;
using MediatR;


namespace HealthChecking.BackEndApi.Application.Features.TestTilgang.Query;

public class GetTilganger : IRequest<IEnumerable<Tilganger>> { }

public class GetTilgangerHandler : IRequestHandler<GetTilganger, IEnumerable<Tilganger>>
{
    private readonly ITilgangService tilgangService;

    public GetTilgangerHandler(ITilgangService tilgangService)
    {
        this.tilgangService = tilgangService;
    }

    public async Task<IEnumerable<Tilganger>> Handle(GetTilganger request, CancellationToken cancellationToken)
    {
        var tilganger = await tilgangService.GetTilganger();

        return tilganger;
    }
}
