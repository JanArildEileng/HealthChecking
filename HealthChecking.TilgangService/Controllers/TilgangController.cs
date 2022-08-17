
using Microsoft.AspNetCore.Mvc;
using MediatR;
using HealthChecking.TilgangService.Application.Queries;
using HealthChecking.Shared.Models;

namespace HealthChecking.TilgangService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TilgangController : ControllerBase
    {
      

        private readonly ILogger<TilgangController> _logger;
        private readonly IMediator mediator;

        public TilgangController(ILogger<TilgangController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetTilganger")]
        public async Task<ActionResult<IEnumerable<Tilganger>>> GetTilganger()
        {
            return Ok(await mediator.Send(new GetTilganger() { }));
        }
    }
}