using System;

namespace Space_Game
{
    public class Ship
    {
        public int fuel; // Will track fuel and fuel capacity
        public int cargoCapacity; // Will track cargo weight capacity 

        //TODO Warp Speed + Travel Costs (W:F)

        List<Load> loads = new List<Load>();

        private int GetCurrentLoad()
        {
            //return loads.Select(l => l.weight).Sum();
            int totalWeight = 0;

            foreach(var load in loads)
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

            if(currentLoad + toAdd.weight <= cargoCapacity)
            {
                loads.Add(toAdd);
            }

            // If the load does exceed the capacity of the truck, throw a "ShipOverLoad" exception
            else
            {
                throw new ShipOverLoadException($"Weight of {toAdd.description} exceeds ship capacity by {weightWithNewLoad - capacity}");
            }
        }

        public void RemoveLoad(Load toRemove)
        {
            loads.Remove(toRemove);
        }

        

    }
}
