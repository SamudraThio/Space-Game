using System;

namespace Space_Game
{
    class Menu
    {
        public bool MainMenu()
        {
            Console.Clear();
            Graphics.MainMenu();
            Graphics.HeadsUpDisplay();
            //DisplayTaskList();

            switch (Console.ReadLine())
            {
                case "1":
                    Graphics.TravelMenu();
                    return true;
                case "2":
                    Graphics.ShoppingMainMenu();
                    return true;
                case "3":
                    Graphics.ShoppingMainMenu();
                    return true;
                case "4":
                    ExitGame.exitGame();
                    return false;
                default:
                    return true;
            }
        }

        public bool TravelMenu()
        {
            Console.Clear();
            Graphics.TravelMenu();
            Graphics.HeadsUpDisplay();

            switch (Console.ReadLine())
            {
                case "1":
                    Planet.Travel(Planet.Earth);
                    return true;
                case "2":
                    TravelTo2();
                    return true;
                case "3":
                    TravelTo3();
                    return true;
                case "4":
                    TravelTo4();
                    return true;
                case "5":
                    TravelTo5();
                    return true;
                case "6":
                    MainMenu();
                    return false;
                default:
                    return true;
            }
        }

        public bool ShoppingMainMenu()
        {
            Console.Clear();
            Graphics.ShoppingMainMenu();
            Graphics.HeadsUpDisplay();

            switch (Console.ReadLine())
            {
                case "1":
                    ShoppingBuyMenu();
                    return true;
                case "2":
                    ShoppingSellMenu();
                    return true;
                case "3":
                    Graphics.ShoppingMainMenu();
                    return false;
                default:
                    return true;
            }
        }

        public bool ShoppingBuyMenu()
        {
            Console.Clear();
            Graphics.ShoppingBuyMenu();
            Graphics.HeadsUpDisplay();

            switch (Console.ReadLine())
            {
                case "1":
                    Shop.BuyItem();
                    return true;
                case "2":
                    Shop.BuyItem();
                    return true;
                case "3":
                    Shop.BuyItem();
                    return true;
                case "4":
                    Shop.BuyFuel();
                    return true;
                case "5":
                    Graphics.ShoppingMainMenu();
                    return false;
                case "6":
                    MainMenu();
                    return false;
                default:
                    return true;
            }
        }

        public bool ShoppingSellMenu()
        {
            Console.Clear();
            Graphics.ShoppingBuyMenu();
            Graphics.HeadsUpDisplay();

            switch (Console.ReadLine())
            {
                case "1":
                    Shop.SellItem();
                    return true;
                case "2":
                    Shop.SellItem();
                    return true;
                case "3":
                    Shop.SellItem();
                    return true;
                case "4":
                    Shop.SellFuel();
                    return true;
                case "5":
                    Graphics.ShoppingMainMenu();
                    return false;
                case "6":
                    MainMenu();
                    return false;
                default:
                    return true;
            }
        }
    }
}