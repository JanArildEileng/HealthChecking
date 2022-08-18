using HealthChecking.BackEndApi.Application.Contracts;
using HealthChecking.BackEndApi.Application.Features.TestTilgang.Query;
using HealthChecking.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthChecking.BackEndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLoggerController : ControllerBase
    {
        private readonly ILogger<TestLoggerController> logger;
        private readonly IMediator mediator;

        public TestLoggerController(ILogger<TestLoggerController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetLogger")]
        public async Task<ActionResult<IEnumerable<LoggInnhold>>> GetLogger([FromServices] ILoggingService loggingService )
        {
            return Ok(await loggingService.GetLogger());
        }


        [HttpPost(Name = "PostLogg")]
        public async Task<ActionResult> PostLogg([FromServices] ILoggingService loggingService,LoggInnhold loggInnhold)
        {
            return Ok(await loggingService.PostLogg(loggInnhold));
        }


    }
}