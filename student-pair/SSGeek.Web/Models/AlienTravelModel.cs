using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSGeek.Web.Models
{
    public class AlienTravelModel
    {
        public string Transportation { get; set; }
        public string Planet { get; set; }
        public double Age { get; set; }
        public double TravelTime
        {
            get
            {
                return (PlanetDistance[Planet] / ModeOfTransportation[Transportation]) / 8760;
            }
        }
        public double AgeAfterTravel
        {
            get
            {
                return TravelTime + Age;
            }
        }

        public static Dictionary<string, double> ModeOfTransportation = new Dictionary<string, double>()
        {
            { "Walking", 3},
            { "Car", 100},
            { "Bullet Train", 200},
            { "Boeing 747", 570},
            { "Concorde", 1350},
        };

        public static Dictionary<string, double> PlanetDistance = new Dictionary<string, double>()
        {
            { "Mercury", 56974146},
            { "Venus", 25724767},
            { "Mars", 48678219},
            { "Jupiter", 390674710},
            { "Saturn", 792248270},
            { "Uranus", 1692662530},
            { "Neptune", 2703959960},
        };


    }
}
