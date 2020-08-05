using System;

namespace Space_Game
{   // This class is for the shop on each planet and the trading system
    public class Shop
    {
        public decimal totalMoney;
        public decimal itemCost;
        // Sets the name of the trader 
        public string Name 
        { 
            get; 
            set;
        }

        // Sets the Items you can buy
        public List<GameItem> Inventory 
        { 
            get; 
            set;
        }
        
        // Sets the name of the Merchant and assigns the items they'll sell
        public Merchant(string name)
        {
            Name = name;
            Inventory = new List<GameItem>();
        }

        public void BuyItem(GameItem item)
        {

            totalMoney = totalMoney - itemCost;
            Inventory.Add(item);
            Console.WriteLine("You bought {description} for {itemCost}.");
        }

        public void SellItem(GameItem item)
        {
            totalMoney = totalMoney + itemCost;
            Inventory.Remove(item);
            Console.WriteLine("You sold {description} for {itemCost}")

        }
    }
    public class List 

    public class PlanetShop
    {
        List<Shop> shopkeepers = new List<Shop>();

        PlantShop()
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