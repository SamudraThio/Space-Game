using System;
using System.Collections.Generic;

namespace SpaceGame
{
    public class Planet
    {
        string planetName;
        public double xcoord;
        public double ycoord;
        public List<string> resources;

        //Stand-in code for the TravelMenu
        public static void Travel()
        {
            Console.WriteLine("Travel To method");
        }



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

        public static Planet AlphaProxima()
        {
            var planetName = "Alpha Proxima";
            var xcoord = 3.0;
            var ycoord = 0.0;

            var resourceName1 = "water";
            var resourceName2 = "oxygen";
            var resourceName3 = "fuel";

            return new Planet(planetName, xcoord, ycoord, new List<string>() { resourceName1, resourceName2, resourceName3 });
        }

        public static Planet Exandria()
        {
            var planetName = "Exandria";
            var xcoord = -3.0;
            var ycoord = 0.0;

            var resourceName1 = "water";
            var resourceName2 = "oxygen";
            var resourceName3 = "fuel";

            return new Planet(planetName, xcoord, ycoord, new List<string>() { resourceName1, resourceName2, resourceName3 });
        }

        public static Planet Midgard()
        {
            var planetName = "Midgard";
            var xcoord = 0.0;
            var ycoord = 3.0;

            var resourceName1 = "water";
            var resourceName2 = "oxygen";
            var resourceName3 = "fuel";

            return new Planet(planetName, xcoord, ycoord, new List<string>() { resourceName1, resourceName2, resourceName3 });
        }

        public static Planet MiddleEarth()
        {
            var planetName = "MiddleEarth";
            var xcoord = 0.0;
            var ycoord = -3.0;

            var resourceName1 = "water";
            var resourceName2 = "oxygen";
            var resourceName3 = "fuel";

            return new Planet(planetName, xcoord, ycoord, new List<string>() { resourceName1, resourceName2, resourceName3 });
        }

       


    }
}