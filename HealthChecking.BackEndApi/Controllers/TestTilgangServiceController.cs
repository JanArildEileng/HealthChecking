using Microsoft.AspNetCore.Mvc;

namespace HealthChecking.BackEndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestTilgangServiceController : ControllerBase
    {
       
        private readonly ILogger<TestTilgangServiceController> _logger;

        public TestTilgangServiceController(ILogger<TestTilgangServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTilgangService")]
        public IEnumerable<string> Get()
        {
            return Enumerable.Range(1, 5).Select(index =>  
                Random.Shared.Next(-20, 55).ToString()
            )
            .ToArray();
        }
    }
}