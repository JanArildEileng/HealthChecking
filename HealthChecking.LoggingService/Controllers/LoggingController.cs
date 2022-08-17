using Microsoft.AspNetCore.Mvc;

namespace HealthChecking.LoggingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingController : ControllerBase
    {
      
        private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLogger")]
        public IEnumerable<Logg> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Logg
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
              
            })
            .ToArray();
        }
    }
}