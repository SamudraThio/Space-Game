using System;
using System.Collections.Generic;

namespace SpaceGame
{
    public class Store
    {
        //Stand-in code for the StoreMenu--------------------------------
        public static void Shop()
        {
            Console.Clear();
            Graphics.ShoppingMainMenu();
            Console.WriteLine("Make a selection:");
            Console.WriteLine();
            Console.ReadLine();

        }
        //---------------------------------------------------------------

        //Stand-in code for the BuyMenu-----------------------------------
        public static void Buy()
        {
            Console.Clear();
            Graphics.ShoppingBuyMenu();
            Console.Write("Make a selection:");
            Console.ReadLine();
            
        }
        //-------------------------------------------------------------------



        // Stand in code for ShoppingBuyMenu
        public static void DisplayInventory()
        {

        }
         
        public static (decimal, int) BuyItem(decimal x, decimal y, int z)
        {
            decimal money = x;
            decimal buyPrice = y;

            int capacity = z;

            try
            {
                if (capacity == 10)
                {
                    throw new IndexOutOfRangeException();
                }

                money = money - buyPrice;

                if (money < 0)
                {
                    money += buyPrice;
                    throw new InputOutofBounds();
                }
                capacity++;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The ship is at max capacity.");
            }
            catch (InputOutofBounds)
            {
                Console.WriteLine("You don't have sufficient funds.");
            }

            return (money, capacity);
        }


        public static (decimal, int) SellItem(decimal x, decimal y, int z)
        {
            decimal money = x;
            decimal sellPrice = y;

            int capacity = z;

            money += sellPrice;
            capacity--;

            return (money, capacity);
        }
    }

    public class Item
    {
        string itemName;
        double buyPrice;
        double sellPrice;

        public Item(string itemName, double buyPrice, double sellPrice)
        {
            this.itemName = itemName;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
        }

        public static List<Item> EarthStore()
        {
            Item water = new Item("Water", 10.00, 10.00);
            Item fuel = new Item("Fuel", 10.00, 10.00);
            Item oxygen = new Item("Oxygen", 10.00, 10.00);

            List<Item> earthStore = new List<Item>() { water, fuel, oxygen };

            return earthStore;
        }
        public static List<Item> AlphaProximaStore()
        {
            Item water = new Item("Water", 10.00, 10.00);
            Item fuel = new Item("Fuel", 10.00, 10.00);
            Item oxygen = new Item("Oxygen", 10.00, 10.00);

            List<Item> alphaProximaStore = new List<Item>() { water, fuel, oxygen };

            return alphaProximaStore;
        }
        public static List<Item> ExandriaStore()
        {
            Item water = new Item("Water", 10.00, 10.00);
            Item fuel = new Item("Fuel", 10.00, 10.00);
            Item oxygen = new Item("Oxygen", 10.00, 10.00);

            List<Item> exandriaStore = new List<Item>() { water, fuel, oxygen };

            return exandriaStore;
        }
        public static List<Item> MidgardStore()
        {
            Item water = new Item("Water", 10.00, 10.00);
            Item fuel = new Item("Fuel", 10.00, 10.00);
            Item oxygen = new Item("Oxygen", 10.00, 10.00);

            List<Item> midgardStore = new List<Item>() { water, fuel, oxygen };

            return midgardStore;
        }
        public static List<Item> MiddleEarthStore()
        {
            Item water = new Item("Water", 10.00, 10.00);
            Item fuel = new Item("Fuel", 10.00, 10.00);
            Item oxygen = new Item("Oxygen", 10.00, 10.00);

            List<Item> middleEarthStore = new List<Item>() { water, fuel, oxygen };

            return middleEarthStore;
        }
    }
    class InputOutofBounds : Exception
    {
        public InputOutofBounds()
        {

        }
    }
}


