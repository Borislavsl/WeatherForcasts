using System;

namespace PirinMountainForcasts
{
    public class PirinMountainForecast
    {
        public DateTime PirinDate { get; set; }

        public int PirinTemperatureC { get; set; }

        public int PirinTemperatureF => 32 + (int)(PirinTemperatureC / 0.5556);

        public string PirinSummary { get; set; }
    }
}
