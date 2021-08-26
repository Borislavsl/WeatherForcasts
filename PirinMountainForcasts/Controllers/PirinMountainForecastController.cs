using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PirinMountainForcasts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PirinMountainForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PirinMountainForecastController> _logger;

        public PirinMountainForecastController(ILogger<PirinMountainForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PirinMountainForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new PirinMountainForecast
            {
                PirinDate = DateTime.Now.AddDays(index),
                PirinTemperatureC = rng.Next(-20, 55),
                PirinSummary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
