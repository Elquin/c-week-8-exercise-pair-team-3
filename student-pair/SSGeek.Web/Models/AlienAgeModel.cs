using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSGeek.Web.Models
{
    public class AlienAgeModel
    {
        public double Age { get; set; }
        public string Planet { get; set; }
        public double AlienAge
        {
            get
            {
                return (365 / AlienAgeConversion[Planet]) * Age;
            }
        }

        public static Dictionary<string, double> AlienAgeConversion = new Dictionary<string, double>()
        {
            { "Mercury", 87.96},
            { "Venus", 224.68},
            { "Mars", 686.98},
            { "Jupiter", 4329.63},
            { "Saturn", 10751.44},
            { "Uranus", 30685.55},
            { "Neptune", 60155.65},
        };
    }
}
