using System;

namespace SpaceGame
{
    
    public class Character
    {
        public double age = 18.0;

        public string name = "Captain Kirk";

        public int totalMoney = 100000;

        public int water = 0;
        public int oxygen = 0;
        public int gold = 0;
        public int totalWeight = 0;
        public const int totalCapacity = 10;
        public const int fuelCapacity = 10;

        //public int waterStock = 0;
        //public int goldStock = 0;
        //public int oxygenStock = 0;
        //TODO: implement trackers for inventory on board (limits implemented by capacity and weight)
    }
}

