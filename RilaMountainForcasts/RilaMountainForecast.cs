using System;

namespace RilaMountainForcasts
{
    public class RilaMountainForecast
    {
        public DateTime RilaDate { get; set; }

        public int RilaTemperatureC { get; set; }

        public int RilaTemperatureF => 32 + (int)(RilaTemperatureC / 0.5556);

        public string RilaSummary { get; set; }
    }
}
