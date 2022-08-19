using HealthChecking.BackEndApi.Application.Contracts;
using HealthChecking.Shared.Models;
using MediatR;

namespace HealthChecking.BackEndApi.Application.Features.TestTilgang.Query;

public class GetTilgang : IRequest<Tilganger> 
{
    public readonly string Navn;

    public GetTilgang(string navn)
    {
        this.Navn = navn;
    }
}

public class GetTilgangHandler : IRequestHandler<GetTilgang, Tilganger?>
{
    private readonly ITilgangService tilgangService;
    private readonly ILoggingService loggingService;

    public GetTilgangHandler(ITilgangService tilgangService, ILoggingService loggingService)
    {
        this.tilgangService = tilgangService;
        this.loggingService = loggingService;
    }

    public async Task<Tilganger?> Handle(GetTilgang request, CancellationToken cancellationToken)
    {
        var tilganger = await tilgangService.GetTilganger();

        var tilgang = tilganger.FirstOrDefault(e => e.Navn.Equals(request.Navn, StringComparison.OrdinalIgnoreCase));
        if (tilgang == null)
           await loggingService.PostLogg(new LoggInnhold($"GetTilgangHandler: '{request.Navn}' ikke funnet i tilganger"));
        else
            await loggingService.PostLogg(new LoggInnhold($"GetTilgangHandler: {request.Navn} => {tilgang} "));

        return tilgang;
    }
}
