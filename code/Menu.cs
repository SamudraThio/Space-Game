using System;

namespace SpaceGame
{
    class Menu
    {
        //TODO get shopping menu's functional
        public static bool MainMenu(Character character, Ship ship)
        {
            Console.Clear();
            Graphics.MainMenu(character, ship);

            switch (Console.ReadLine())
            {
                case "1":
                    TravelMenu(character, ship);
                    return true;
                case "2":
                    ShoppingMainMenu(character, ship);
                    return true;
                case "3":
                    ShoppingMainMenu(character, ship);
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
                    ship.Travel(Planet.Exandria());
                    return true;
                case "4":
                    ship.Travel(Planet.Midgard());
                    return true;
                case "5":
                    ship.Travel(Planet.MiddleEarth());
                    return true;
                default:
                    return true;
            }
        }

        public static bool ShoppingMainMenu(Character character, Ship ship)
        {
            Console.Clear();
            Graphics.ShoppingMainMenu(character, ship);

            switch (Console.ReadLine())
            {
                case "1":
                    ShoppingBuyMenu(character, ship);
                    return true;
                case "2":
                    ShoppingSellMenu(character, ship);
                    return true;
                case "3":
                    Graphics.ShoppingMainMenu(character, ship);
                    return true;
                default:
                    return true;
            }
        }

        public static bool ShoppingBuyMenu(Character character, Ship ship)
        {
            Console.Clear();
            Graphics.ShoppingBuyMenu(character, ship);

            switch (Console.ReadLine())
            {
                case "1":
                    Store.BuyItem();
                    return true;
                case "2":
                    Store.BuyItem();
                    return true;
                case "3":
                    Store.BuyItem();
                    return true;
                case "4":
                    Store.BuyItem();
                    return true;
                case "5":
                    Graphics.ShoppingMainMenu(character, ship);
                    return true;
                case "6":
                    MainMenu(character, ship);
                    return true;
                default:
                    return true;
            }
        }

        public static bool ShoppingSellMenu(Character character, Ship ship)
        {
            Console.Clear();
            Graphics.ShoppingBuyMenu(character, ship);

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
                    Graphics.ShoppingMainMenu(character, ship);
                    return true;
                case "6":
                    MainMenu(character, ship);
                    return true;
                default:
                    return true;
            }
        }
    }
}