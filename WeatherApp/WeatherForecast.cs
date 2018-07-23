using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherForecast
    {
        public city city { get; set; }
        public List<list> list { get; set; } // forecast list
    }

    public class temp
    {
        public double day { get; set; }
    }

    public class weather
    {
        public string main { get; set; } // weather condition
        public string description { get; set; }
    }

    public class city
    {
        public string name { get; set; }
    }

    public class list
    {
        public double dt { get; set; } // day in milliseconds
        public double pressure { get; set; } // hpa
        public double humidity { get; set; } // %
        public double speed { get; set; } // wind speed in km/h

        public temp temp { get; set; }
        public List<weather> weather { get; set; }
    }
}