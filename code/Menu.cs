using System;

namespace SpaceGame
{
    class Menu
    {
        public static bool MainMenu()
        {
            Console.Clear();
            Graphics.MainMenu();
            //DisplayTaskList();

            switch (Console.ReadLine())
            {
                case "1":
                    Planet.Travel();
                    return true;
                case "2":
                    Store.Shop();
                    return true;
                case "3":
                    Store.Shop();
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

            switch (Console.ReadLine())
            {
                case "1":
                    Planet.Travel();
                    return true;
                case "2":
                    Planet.Travel();
                    return true;
                case "3":
                    Planet.Travel();
                    return true;
                case "4":
                    Planet.Travel();
                    return true;
                case "5":
                    Planet.Travel();
                    return true;
                case "6":
                    MainMenu();
                    return true;
                default:
                    return true;
            }
        }

        public bool ShoppingMainMenu()
        {
            Console.Clear();
            Graphics.ShoppingMainMenu();

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

            switch (Console.ReadLine())
            {
                case "1":
                    Store.Buy();
                    return true;
                case "2":
                    Store.Buy();
                    return true;
                case "3":
                    Store.Buy();
                    return true;
                case "4":
                    Store.Buy();
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

            switch (Console.ReadLine())
            {
                case "1":
                    Store.SellItem();
                    return true;
                case "2":
                    Store.SellItem();
                    return true;
                case "3":
                    Store.SellItem();
                    return true;
                case "4":
                    Store.SellItem();
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