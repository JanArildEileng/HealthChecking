using MediatR;

using HealthChecking.TilgangService.Domain.Entities;
using HealthChecking.TilgangService.Domain.Repositories;
using AutoMapper;

namespace HealthChecking.TilgangService.Application.Queries;

public class GetTilganger : IRequest<IList<HealthChecking.Shared.Models.Tilganger>> { }

public class GetTilgangerHandler : IRequestHandler<GetTilganger, IList<HealthChecking.Shared.Models.Tilganger>>
{
    private readonly ITilgangRespository tilgangRespository;
    private readonly IMapper mapper;

    public GetTilgangerHandler(ITilgangRespository tilgangRespository,IMapper mapper)
    {
        this.tilgangRespository = tilgangRespository;
        this.mapper = mapper;
    }

   

    public async Task<IList<HealthChecking.Shared.Models.Tilganger>> Handle(GetTilganger request, CancellationToken cancellationToken)
    {
        var tilganger = await tilgangRespository.GetTilganger();
        return mapper.Map<List<HealthChecking.Shared.Models.Tilganger>>(tilganger);
    }
}
