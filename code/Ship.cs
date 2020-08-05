using System;
using System.Collections.Generic;

namespace SpaceGame
{

    public class Ship
    {
        public int fuel; // Will track fuel and fuel capacity
        public int cargoCapacity; // Will track cargo weight capacity 
        public Planet currentPlanet; //Will Track current location of the ship

        //TODO Warp Speed + Travel Costs (W:F)

        List<Load> loads = new List<Load>();

        private int GetCurrentLoad()
        {
            //return loads.Select(l => l.weight).Sum();
            int totalWeight = 0;

            foreach (var load in loads)
            {
                totalWeight += load.weight;
            }

            return totalWeight;
        }

        public void AddLoad(Load toAdd)
        {
            // If the load does not exceed the capacity of the ship, add it
            var currentLoad = GetCurrentLoad();
            var weightWithNewLoad = currentLoad + toAdd.weight;

            if (currentLoad + toAdd.weight <= cargoCapacity)
            {
                loads.Add(toAdd);
            }

            // If the load does exceed the capacity of the truck, throw a "ShipOverLoad" exception
            else
            {
                //This probably needs to be console.writeline
                //throw new ShipOverLoadException($"Weight of {toAdd.description} exceeds ship capacity by {weightWithNewLoad - capacity}");
            }
        }

        public void RemoveLoad(Load toRemove)
        {
            loads.Remove(toRemove);
        }

        public double Distance(Planet newPlanet)
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

        public Planet Travel(Planet newPlanet)
        {
            //TODO: TotalFuel =- FuelBurned
            //Given Warp speed (W) with non-inclusive bounds of 0 and 10, velocity in multiples of the speed of light = W^(10/3)  + (10 ? W)^(-11/3).

            //int warpLevel = 0;


            currentPlanet = newPlanet;
            return currentPlanet;

        }
    }
}
