using HealthChecking.BackEndApi.Application.Features.TestTilgang.Query;
using HealthChecking.BackEndApi.Application.Models;
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
    }
}