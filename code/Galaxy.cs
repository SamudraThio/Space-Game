using System;
using System.Collections.Generic;

namespace Space_Game
{
    public class Planet
    {
        string planetName;
        public double xcoord;
        public double ycoord;
        public List<string> resources;

        public Planet(string planetName, double xcoord, double ycoord, List<string> resources)
        {
            this.planetName = planetName;
            this.xcoord = xcoord;
            this.ycoord = ycoord;
            this.resources = resources;
        }

        public static Planet Earth()
        {
            var planetName = "Earth";
            var xcoord = 0.0;
            var ycoord = 0.0;

            var resourceName1 = "water";
            var resourceName2 = "oxygen";
            var resourceName3 = "fuel";

            return new Planet(planetName, xcoord, ycoord, new List<string>() { resourceName1, resourceName2, resourceName3 });
        }

        public void AlphaProxima()
        {
            planetName = "Alpha Proxima";
            xcoord = 3.0;
            ycoord = 0.0;

            resourceName1 = "water";
            resourceName2 = "oxygen";
            resourceName3 = "fuel";
        }

        public void Exandria()
        {
            planetName = "Exandria";
            xcoord = -3.0;
            ycoord = 0.0;

            resourceName1 = "water";
            resourceName2 = "oxygen";
            resourceName3 = "fuel";
        }

        public void Midgard()
        {
            planetName = "Midgard";
            xcoord = 0.0;
            ycoord = 3.0;

            resourceName1 = "water";
            resourceName2 = "oxygen";
            resourceName3 = "fuel";
        }

        public void MiddleEarth()
        {
            planetName = "MiddleEarth";
            xcoord = 0.0;
            ycoord = -3.0;

            resourceName1 = "water";
            resourceName2 = "oxygen";
            resourceName3 = "fuel";
        }

        public void Travel()
        {
            //TODO: Distance / Fuel Units = FuelBurned
            //Given Warp speed (W) with non-inclusive bounds of 0 and 10, velocity in multiples of the speed of light = W^(10/3)  + (10 − W)^(-11/3).
            
        }


    }
}