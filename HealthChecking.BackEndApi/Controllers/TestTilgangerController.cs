using HealthChecking.BackEndApi.Application.Features.TestTilgang.Query;
using HealthChecking.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthChecking.BackEndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestTilgangerController : ControllerBase
    {
        private readonly ILogger<TestTilgangerController> logger;
        private readonly IMediator mediator;

        public TestTilgangerController(ILogger<TestTilgangerController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetTilganger")]
        public async Task<ActionResult<IEnumerable<Tilganger>>> GetTilganger()
        {
            return Ok(await mediator.Send(new GetTilganger() { }));
        }

        [HttpGet("Navn", Name = "GetTilgang")]
        public async Task<ActionResult<Tilganger>> GetTilgang(string Navn)
        {
            var tilgang = await mediator.Send(new GetTilgang(Navn));
            if (tilgang == null)
                return NotFound($"{Navn} ikke funnet i tilgangskontroll");

            return Ok(tilgang);
        }


    }
}