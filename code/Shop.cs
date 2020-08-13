using System;
using System.Collections.Generic;

namespace SpaceGame
{
    public class Store
    {
        public static List<Item> inventorys = new List<Item>();
        public static List<Load> loads = new List<Load>();

        // Pulls the current planet's store and displays the items, buying price, and selling price.
        public static void DisplayStore(Planet currentPlanet)
        {
            var lists = currentPlanet.shop;
            Console.WriteLine("Item Name:          Buy Price:          Sell Price:          ");
            foreach (var list in lists)
            {
                Console.WriteLine($"{list.itemName}                    {list.buyPrice}                    {list.sellPrice}");
            }
            Console.WriteLine("0: Water | 1: Oxygen | 2: Gold | 3: Fuel");
        }

        // Displays the inventory - used when looking for items to sell.
        public static void DisplayInventory(Character character, Ship ship, Planet planet, Store store)
        {
            if (inventorys.Count == 0)
            {
                Console.WriteLine("You have nothing to in your inventory.");
                Console.ReadLine();
                Menu.ShoppingMainMenu(character, ship, planet, store);

            }
            else
            {
                Console.WriteLine("Inventory List(Select the number below for the item you want to sell.");
                for (int i = 0; i < inventorys.Count; i++)
                {
                    Console.WriteLine($"{i  +  1}. {inventorys[i].itemName}");
                }
            }
        }

        // Counts up the total number of items the user has for the status menu.
        public void InventoryCount()
        {
            int waterCount = 0;
            int oxygenCount = 0;
            int goldCount = 0;

            for (int i = 0; i < inventorys.Count; i++)
            {
                string counter = inventorys[i].itemName;

                if (counter.StartsWith("W"))
                {
                    waterCount++;
                }
                else if (counter.StartsWith("G"))
                {
                    goldCount++;
                }
                else if (counter.StartsWith("O"))
                {
                    oxygenCount++;
                }
            }
        }

        // Checks if the character is going to be over weight. Used in the buy and sell function.
        public static int GetCurrentCapacity(Character character)
        {
            foreach (var load in loads)
            {
                character.totalWeight += load.weight;

                if (character.totalWeight > Character.totalCapacity)
                {
                    Console.WriteLine("The ship is overloaded, Captain! We have to sell off some goods before we can take off!");
                    Console.ReadLine();
                }
            }

            return character.totalWeight;
        }

        // First step of buying: Selects which item you want to buy.
        public static string SelectItemToBuy(Planet currentPlanet)
        {
        LOOP:
            Console.WriteLine("Enter the number of the item you would like to buy: ");
            int i = int.Parse(Console.ReadLine());
            string buyItemName = "";
            if (i < 0 || i > 5)
            {
                Console.WriteLine("Did not input a valid item number.");
                goto LOOP;
            }
            else
            {
                buyItemName = currentPlanet.shop[i].itemName;
            }
            return buyItemName;
        }

        // Second step of buying: Buys an item from the planet store, subtracts from total money, and adds one to total weight.
        public static (int, int) BuyItem(Character character, Planet currentPlanet, string itemName)
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
                    
                    if (itemName.StartsWith("W"))
                    {
                        inventorys.Add(currentPlanet.shop[0]);
                        character.water++;
                        character.totalWeight++;
                    }
                    else if (itemName.StartsWith("G"))
                    {
                        inventorys.Add(currentPlanet.shop[2]);
                        character.gold++;
                        character.totalWeight++;
                    }
                    else if (itemName.StartsWith("O"))
                    {
                        inventorys.Add(currentPlanet.shop[1]);
                        character.oxygen++;
                        character.totalWeight++;
                    }
                    else if (itemName.StartsWith("F"))  
                    {
                        if (character.fuel >= 10)
                        {
                            Console.WriteLine("We're all maxed out on fuel, Captain!");
                            Console.ReadLine();
                        }
                        else
                        {
                            character.fuel++;
                        }
                    }

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


        // First step to selling: Lets the user select which item they want to sell from the list.
        public static (int, string) SelectItemToSell(Planet currentPlanet, Character character)
        {
        LOOP:
            int position;
            string sellItemName = "";
            Console.WriteLine();
            Console.WriteLine("Enter the number of the item you would like to sell: ");
            int i = int.Parse(Console.ReadLine());
            position = i - 1;
            if (inventorys[position] != null)
            {
                sellItemName = inventorys[position].itemName;

                if (sellItemName.StartsWith("W"))
                {
                    character.water--;
                }
                else if (sellItemName.StartsWith("G"))
                {
                    character.gold--;
                }
                else if (sellItemName.StartsWith("O"))
                {
                    character.oxygen--;
                }
            }
            else
            {
                Console.WriteLine("Did not input a valid item number.");
                goto LOOP;
            }
            return (position, sellItemName);
        }

        // Second step to selling: Sells an item to the planet store, adds money to total money, removes the item from the list, and decrements total weight.
        public static void SellItem(Character character, Planet currentPlanet, string itemName, int position)
        {

            int price = Item.PurchaseCostOf(itemName, currentPlanet.shop);

            character.totalMoney += price;
            inventorys.RemoveAt(position);

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
            Item water = new Item("Water", 5000, 5000);
            Item oxygen = new Item("Oxygen", 5000, 5000);
            Item gold = new Item("Gold", 5000, 5000);
            Item fuel = new Item("Fuel", 500, 500);

            List<Item> earthStore = new List<Item>() { water, oxygen, gold, fuel };

            return earthStore;
        }
        public static List<Item> AlphaProximaStore()
        {
            Item water = new Item("Water", 7500, 7500);
            Item oxygen = new Item("Oxygen", 2500, 2500);
            Item gold = new Item("Gold", 5000, 5000);
            Item fuel = new Item("Fuel", 500, 500);

            List<Item> alphaProximaStore = new List<Item>() { water, oxygen, gold, fuel };

            return alphaProximaStore;
        }
        public static List<Item> ExandriaStore()
        {
            Item water = new Item("Water", 2500, 2500);
            Item oxygen = new Item("Oxygen", 7500, 7500);
            Item gold = new Item("Gold", 5000, 5000);
            Item fuel = new Item("Fuel", 500, 500);

            List<Item> exandriaStore = new List<Item>() { water, oxygen, gold, fuel };

            return exandriaStore;
        }
        public static List<Item> MidgardStore()
        {
            Item water = new Item("Water", 5000, 5000);
            Item oxygen = new Item("Oxygen", 7500, 7500);
            Item gold = new Item("Gold", 2500, 2500);
            Item fuel = new Item("Fuel", 500, 500);

            List<Item> midgardStore = new List<Item>() { water, oxygen, gold, fuel };

            return midgardStore;
        }
        public static List<Item> MiddleEarthStore()
        {
            Item water = new Item("Water", 2500, 2500);
            Item oxygen = new Item("Oxygen", 5000, 5000);
            Item gold = new Item("Gold", 7500,7500);
            Item fuel = new Item("Fuel", 500, 500);

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
}



