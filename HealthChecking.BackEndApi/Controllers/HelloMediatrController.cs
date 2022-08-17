using HealthChecking.BackEndApi.Application.Features.TestMediatR.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthChecking.BackEndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloMediatrController : ControllerBase
    {
       
        private readonly ILogger<HelloMediatrController> _logger;
        private readonly IMediator mediator;

        public HelloMediatrController(ILogger<HelloMediatrController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "Hello")]
        public async Task<ActionResult<string>> Hello()
        {
            return Ok(await mediator.Send(new HelloMediatr() { }));
        }
    }
}