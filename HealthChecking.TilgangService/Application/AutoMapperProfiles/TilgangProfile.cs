using AutoMapper;

namespace HealthChecking.TilgangService.Application.AutoMapperProfiles;

public class TilgangProfile : Profile
{
    public TilgangProfile()
    {
        CreateMap<HealthChecking.TilgangService.Domain.Entities.Tilganger, HealthChecking.Shared.Models.Tilganger>()
            .ReverseMap();
    }
    
}
