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
        public static void BuyItem()
        {
            Console.WriteLine("BuyItem function here");
        }

        public static void SellItem()
        {
            Console.WriteLine("SellItem function here");
        }
    }

    // Items are marked with the name and price
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
}









/* This class is for the shop on each planet and the trading system

public class Shop
{
    public decimal totalMoney; // Can we pull this from Character class?

    // Sets the name of the Merchant 
    public string MerchantName
    {
        get;
        set;
    }

    // Sets the store inventory
    public class StoreInventory
    {
        List<string> storeInventory = new List<string>();
        storeInventory.Add("Water");
        storeInventory.Add("Fuel");
        storeInventory.Add("Oxygen");

    }

    // Sets the name of the Merchant and assigns the items they'll sell
    public Shop(string name)
    {
        MerchantName = name;
        storeInventory.Add(Water);
        storeInventory.Add(Fuel);
        storeInventory.Add(Oxygen);
    }

    public void BuyItem(StoreItems item)
    {

        totalMoney = totalMoney - itemCost;
        Inventory.Add(item);
        Console.WriteLine("You bought {description} for {itemCost}.");
    }

    public void SellItem(StoreItems item)
    {
        totalMoney = totalMoney + itemCost;
        Inventory.Remove(item);
        Console.WriteLine("You sold {description} for {itemCost}");

    }
}
public class List
{ }

public class PlanetShop
{
    List<Shop> shopkeepers = new List<Shop>();

    public PlanetShop()
    {
        Shop john = new Shop("John");
        john.AddItemToInventory();

        Shop cody = new Shop("Cody");
        cody.AddItemToInventory();

        Shop sam = new Shop("Sam");
        sam.AddItemToInventory();

        shopkeepers.add();
    }
}

*/

