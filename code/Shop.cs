using System;
using System.Collections.Generic;

namespace SpaceGame
{
    //TODO clean up red squigley's in Store
    public class Store
    {
        public List<Item> inventory = new List<Item>();
        List<Load> loads = new List<Load>();
        

        public int GetCurrentCapacity(Character character)
        {
            //return loads.Select(l => l.weight).Sum();
            character.totalWeight = 0;

            foreach (var load in loads)
            {
                character.totalWeight += load.weight;

                if (character.totalWeight > Character.totalCapacity)
                {
                    Console.WriteLine("The ship is overloaded, Captain! We have to sell off some goods before we can take off!");
                }
            }

            return character.totalWeight;
        }


         
        public (int, int) BuyItem(Character character, Planet currentPlanet, int i)
        {
            try
            {
                var currentLoad = GetCurrentCapacity(character);
                

                if (character.totalWeight == Character.totalCapacity)
                {
                    Console.WriteLine("The ship is at max capacity.");
                    throw new IndexOutOfRangeException();
                }

                if (character.totalMoney < currentPlanet.shop[0])
                {
                    throw new InputOutofBounds();
                }
                else
                {
                    character.totalMoney = character.totalMoney - buyPrice;
                    character.totalWeight++;
                }
                
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The ship is at max capacity.");
            }
            catch (InputOutofBounds)
            {
                Console.WriteLine("You don't have sufficient funds.");
            }

            return (character.totalMoney, character.totalWeight);
        }


        public void SellItem(Item item, Character character)
        {

            character.totalMoney += Item.SellingCostOf(item);

            inventory.Remove(item);
            character.totalWeight--;

        }
    }

    public class Item
    {
        public string itemName;
        public int buyPrice;
        public int sellPrice;

        public Item(string itemName, int buyPrice, int sellPrice)
        {
            this.itemName = itemName;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
        }

        public static List<Item> EarthStore()
        {
            Item water = new Item("Water", 100, 100);
            Item oxygen = new Item("Oxygen", 100, 100);
            Item gold = new Item("Gold", 100, 100);
            Item fuel = new Item("Fuel", 50, 50);

            List<Item> earthStore = new List<Item>() { water, oxygen, gold, fuel };

            return earthStore;
        }
        public static List<Item> AlphaProximaStore()
        {
            Item water = new Item("Water", 100, 100);
            Item oxygen = new Item("Oxygen", 100, 100);
            Item gold = new Item("Gold", 100, 100);
            Item fuel = new Item("Fuel", 50, 50);

            List<Item> alphaProximaStore = new List<Item>() { water, oxygen, gold, fuel };

            return alphaProximaStore;
        }
        public static List<Item> ExandriaStore()
        {
            Item water = new Item("Water", 100, 100);
            Item oxygen = new Item("Oxygen", 100, 100);
            Item gold = new Item("Gold", 100, 100);
            Item fuel = new Item("Fuel", 50, 50);

            List<Item> exandriaStore = new List<Item>() { water, oxygen, gold, fuel };

            return exandriaStore;
        }
        public static List<Item> MidgardStore()
        {
            Item water = new Item("Water", 100, 100);
            Item oxygen = new Item("Oxygen", 100, 100);
            Item gold = new Item("Gold", 100, 100);
            Item fuel = new Item("Fuel", 50, 50);

            List<Item> midgardStore = new List<Item>() { water, oxygen, gold, fuel };

            return midgardStore;
        }
        public static List<Item> MiddleEarthStore()
        {
            Item water = new Item("Water", 100, 100);
            Item oxygen = new Item("Oxygen", 100, 100);
            Item gold = new Item("Gold", 100, 100);
            Item fuel = new Item("Fuel", 50, 50);

            List<Item> middleEarthStore = new List<Item>() { water, oxygen, gold, fuel };

            return middleEarthStore;
        }
        public int PurchaseCostOf(Item item)
        {
            return item.buyPrice;
        }
        public int SellingCostOf(Item item)
        {
            return item.SellPrice;
        }


    }
    class InputOutofBounds : Exception
    {
        public InputOutofBounds()
        {

        }
    }

    class ShipOverLoad : Exception
    {
        public ShipOverLoad()
        {

        }
    }
}


