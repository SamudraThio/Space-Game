using System;
using System.Collections.Generic;

namespace SpaceGame
{
    public class Planet
    {
        public string planetName;
        public double xcoord;
        public double ycoord;
        public List<Item> shop;

        public Planet()
        {

        }
        
        public Planet(string planetName, double xcoord, double ycoord, List<Item> shop)
        {
            this.planetName = planetName;
            this.xcoord = xcoord;
            this.ycoord = ycoord;
            this.shop = shop;
        }

        public static Planet Earth()
        {
            var planetName = "Earth";
            var xcoord = 0.0;
            var ycoord = 0.0;
            var shop = Item.EarthStore();

            return new Planet(planetName, xcoord, ycoord, shop);
        }

        public static Planet AlphaProxima()
        {
            var planetName = "Alpha Proxima";
            var xcoord = 300.0;
            var ycoord = 0.0;
            var shop = Item.AlphaProximaStore();

            return new Planet(planetName, xcoord, ycoord, shop);
        }

        public static Planet Exandria()
        {
            var planetName = "Exandria";
            var xcoord = -300.0;
            var ycoord = 0.0;
            var shop = Item.ExandriaStore();

            return new Planet(planetName, xcoord, ycoord, shop);
        }

        public static Planet Midgard()
        {
            var planetName = "Midgard";
            var xcoord = 0.0;
            var ycoord = 300.0;
            var shop = Item.MidgardStore();

            return new Planet(planetName, xcoord, ycoord, shop);
        }

        public static Planet MiddleEarth()
        {
            var planetName = "MiddleEarth";
            var xcoord = 0.0;
            var ycoord = -300.0;
            var shop = Item.MiddleEarthStore();

            
            return new Planet(planetName, xcoord, ycoord, shop);
        }

    }
}