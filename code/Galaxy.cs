using System;

namespace Space_Game
{
    public class Planet
    {
        string planetName;
        double xcoord;
        double ycoord;
        string resourceName1;
        string resourceName2;
        string resourceName3;

        public void Earth()
        {
            planetName = "Earth";
            xcoord = 0.0;
            ycoord = 0.0;

            resourceName1 = "water";
            resourceName2 = "oxygen";
            resourceName3 = "fuel";
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
        public double Distance(Planet currentPlanet, Planet newPlanet)
        {
            //Pulls distance using coordinates of the current planet and new planet

            double x1 = currentPlanet.xcoord;
            double y1 = currentPlanet.ycoord;
            double x2 = newPlanet.xcoord;
            double y2 = newPlanet.ycoord;

            double findx = Math.Pow(x2 - x1, 2);
            double findy = Math.Pow(y2 - y1, 2);

            double distance = Math.Sqrt(findx + findy);

            return distance;
        }


    }
}