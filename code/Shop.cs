using System;
using System.Collections.Generic;

namespace SpaceGame
{
    //TODO clean up red squigley's in Store
    public class Store
    {
        public List<Item> inventorys = new List<Item>();
        List<Load> loads = new List<Load>();

        public void DisplayStore(Planet currentPlanet)
        {
            var lists = currentPlanet.shop;
            Console.WriteLine("Item Name:          Buy Price:          Sell Price:          ");
            foreach (var list in lists)
            {
                Console.WriteLine($"{list.itemName}          {list.buyPrice}          {list.sellPrice}");
            }
        }

        public void DisplayInventory()
        {
            if (inventorys.Count == 0)
            {
                Console.WriteLine("You have nothing to sell");
            }
            else
            {
                for (int i = 0; i < inventorys.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {inventorys[i]}");
                }
            }
        }

        public void SelectItemToSell(Character character, Planet currentPlanet)
        {
            Console.WriteLine("Enter the number of the item you would like to sell: ");
            int i = int.Parse(Console.ReadLine());
            if (inventory[i] != NULL)
            {
                string selectedItem = inventorys[i].itemName;
                SellItem(character, currentPlanet, selectedItem);
            }
            else
            {
                cw
            }
        }

        public int GetCurrentCapacity(Character character)
        {
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


         
        public (int, int) BuyItem(Character character, Planet currentPlanet, string itemName)
        {
            try
            {
                var currentLoad = GetCurrentCapacity(character);
                

                if (character.totalWeight == Character.totalCapacity)
                {
                    Console.WriteLine("The ship is at max capacity.");
                    throw new IndexOutOfRangeException();
                }

                int price = Item.PurchaseCostOf(itemName, currentPlanet.shop);

                if (character.totalMoney < price)
                {
                    throw new InputOutofBounds();
                }
                else
                {
                    character.totalMoney = character.totalMoney - price;
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


        public void SellItem(Character character, Planet currentPlanet, string itemName)
        {

                int price = Item.PurchaseCostOf(itemName, currentPlanet.shop);

                character.totalMoney += price;

                // inventory.Remove(item);

                character.totalWeight--;
            }
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
        public static int PurchaseCostOf(string itemName, List<Item> shop)
        {
            int price = 0;
            foreach (var item in shop)
            {
                if (item.itemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                    price = item.buyPrice;
            }
            return price;
        }

        public static int SellingCostOf(string itemName, List<Item> shop)
        {
            int price = 0;
            foreach (var item in shop)
            {
                if (item.itemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                    price = item.sellPrice;
            }
            return price;
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



