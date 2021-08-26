using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RilaMountainForcasts.Controllers
{
    [ApiController]
    
    public class RilaMountainForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<RilaMountainForecastController> _logger;

        public RilaMountainForecastController(ILogger<RilaMountainForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/Forcasts")]
        public IEnumerable<RilaMountainForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new RilaMountainForecast
            {
                RilaDate = DateTime.Now.AddDays(index),
                RilaTemperatureC = rng.Next(-20, 55),
                RilaSummary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
