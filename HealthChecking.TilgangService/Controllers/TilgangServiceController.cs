using Microsoft.AspNetCore.Mvc;

namespace HealthChecking.TilgangService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TilgangServiceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<TilgangServiceController> _logger;

        public TilgangServiceController(ILogger<TilgangServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTilganger")]
        public IEnumerable<Tilganger> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Tilganger
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}