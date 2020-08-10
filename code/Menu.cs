using System;

namespace SpaceGame
{
    class Menu
    {
        public static bool MainMenu(Character character, Ship ship)
        {
            Console.Clear();
            Graphics.MainMenu(character, ship);
            //DisplayTaskList();

            switch (Console.ReadLine())
            {
                case "1":
                    TravelMenu(character, ship);
                    return true;
                case "2":
                    //Store.Shop();
                    return true;
                case "3":
                    //Store.Shop();
                    return true;
                case "4":
                    ExitGame.exitGame();
                    return false;
                default:
                    return true;
            }
        }

        public static bool TravelMenu(Character character, Ship ship)
        {
            Console.Clear();
            Graphics.TravelMenu(character, ship);

            switch (Console.ReadLine())
            {
                case "1":
                    ship.Travel(Planet.Earth());
                    return true;
                case "2":
                    ship.Travel(Planet.AlphaProxima());
                    return true;
                case "3":
                    ship.Travel(Planet.Earth());
                    return true;
                case "4":
                    ship.Travel(Planet.Earth());
                    return true;
                case "5":
                    ship.Travel(Planet.Earth());
                    return true;
                default:
                    return true;
            }
        }

        //public bool ShoppingMainMenu()
        //{
        //    Console.Clear();
        //    Graphics.ShoppingMainMenu();

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            ShoppingBuyMenu();
        //            return true;
        //        case "2":
        //            ShoppingSellMenu();
        //            return true;
        //        case "3":
        //            Graphics.ShoppingMainMenu();
        //            return false;
        //        default:
        //            return true;
        //    }
        //}

        //public bool ShoppingBuyMenu(Character character, Ship ship)
        //{
        //    Console.Clear();
        //    Graphics.ShoppingBuyMenu(character, ship);

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            Store.Buy();
        //            return true;
        //        case "2":
        //            Store.Buy();
        //            return true;
        //        case "3":
        //            Store.Buy();
        //            return true;
        //        case "4":
        //            Store.Buy();
        //            return true;
        //        case "5":
        //            Graphics.ShoppingMainMenu();
        //            return false;
        //        case "6":
        //            //MainMenu();
        //            return false;
        //        default:
        //            return true;
        //    }
        //}

        //public bool ShoppingSellMenu()
        //{
        //    Console.Clear();
        //    Graphics.ShoppingBuyMenu();

        //    switch (Console.ReadLine())
        //    {
        //        //case "1":
        //        //    Store.SellItem();
        //        //    return true;
        //        //case "2":
        //        //    Store.SellItem();
        //        //    return true;
        //        //case "3":
        //        //    Store.SellItem();
        //        //    return true;
        //        //case "4":
        //        //    Store.SellItem();
        //        //    return true;
        //        //case "5":
        //        //    Graphics.ShoppingMainMenu();
        //        //    return false;
        //        //case "6":
        //        //    MainMenu();
        //        //    return false;
        //        //default:
        //        //    return true;
        //    }
        //}
    }
}