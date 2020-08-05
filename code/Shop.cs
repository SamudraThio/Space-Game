using System;
using System.Collections.Generic;

namespace Space_Game
{   // This class is for the shop on each planet and the trading system

    public class StoreItems : List<StoreItems>
    {
        public string itemName
        {
            get;
            set;
        }
        
        public decimal itemCost
        {
            get;
            set;
        }
    }

    public class Shop
    {
        public decimal totalMoney; // Can we pull this from Character class?

        // Sets the name of the Merchant 
        public string Name
        {
            get;
            set;
        }

        // Sets the store inventory
        public class StoreInventory
        {
            List<StoreItems> storeinventory = new List<StoreItems>();
        }

        // Sets the name of the Merchant and assigns the items they'll sell
        public Shop(string name)
        {
            Name = name;
            Inventory = new List<StoreItems>();
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
}