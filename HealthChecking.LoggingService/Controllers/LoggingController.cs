using Microsoft.AspNetCore.Mvc;

using HealthChecking.Shared.Models;

namespace HealthChecking.LoggingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingController : ControllerBase
    {
      
        private readonly ILogger<LoggingController> _logger;

        static List<LoggInnhold> loggInnholdListe = new();

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLogger")]
        public ActionResult<List<LoggInnhold>> Get()
        {
            return Ok(loggInnholdListe);
        }

        [HttpPost(Name = "PostLogg")]
        public ActionResult Post(LoggInnhold loggInnhold)
        {
            loggInnholdListe.Add(loggInnhold with { opprettet = DateTime.Now });
            return Ok();
        }

    }
}