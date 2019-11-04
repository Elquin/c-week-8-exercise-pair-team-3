using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SSGeek.Web.Models
{
    public class AlienWeightModel
    {
        public double EarthWeight { get; set; }
        public double AlienWeight
        {
            get
            {
                return EarthWeight * Planets[Planet];
            }
        }
        public string Planet { get; set; }


        public AlienWeightModel(double earthWeight, string planet)
        {
            EarthWeight = earthWeight;
            Planet = planet;
        }

        public Dictionary<string, double> Planets = new Dictionary<string, double>()
        {
            { "Mercury", 0.37},
            { "Venus", 0.90},
            { "Mars", 0.38},
            { "Jupiter", 2.65},
            { "Saturn", 1.13},
            { "Uranus", 1.09},
            { "Neptune", 1.43},
        };

    }

}