using System;

namespace SpaceGame
{
    class Menu
    {
        //TODO get shopping menu's functional
        public static bool MainMenu(Character character, Ship ship, Planet planet, Store store)
        {
            Console.Clear();
            Graphics.MainMenu(character, ship);

            switch (Console.ReadLine())
            {
                case "1":
                    TravelMenu(character, ship);
                    return true;
                case "2":
                    ShoppingMainMenu(character, ship, planet, store);
                    return true;
                case "3":
                    ShoppingMainMenu(character, ship, planet, store);
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
                    ship.Travel(character, Planet.Earth());
                    return true;
                case "2":
                    ship.Travel(character, Planet.AlphaProxima());
                    return true;
                case "3":
                    ship.Travel(character, Planet.Exandria());
                    return true;
                case "4":
                    ship.Travel(character, Planet.Midgard());
                    return true;
                case "5":
                    ship.Travel(character, Planet.MiddleEarth());
                    return true;
                default:
                    return true;
            }
        }

        public static bool ShoppingMainMenu(Character character, Ship ship, Planet planet, Store store)
        {
            Console.Clear();
            Graphics.ShoppingMainMenu(character, ship);
            Store.DisplayStore(ship.currentPlanet);

            switch (Console.ReadLine())
            {
                case "1":
                    string buyItemName = Store.SelectItemToBuy(ship.currentPlanet);
                    Store.BuyItem(character, ship.currentPlanet, buyItemName);
                    return true;
                case "2":
                    Store.DisplayInventory();
                    (int position, string sellItemName) = Store.SelectItemToSell(ship.currentPlanet);
                    Store.SellItem(character, ship.currentPlanet, sellItemName, position);
                    return true;
                case "3":
                    Graphics.ShoppingMainMenu(character, ship);
                    return true;
                default:
                    return true;
            }
        }

        //public static bool ShoppingBuyMenu(Character character, Ship ship, Planet planet)
        //{
        //    Console.Clear();
        //    Graphics.ShoppingBuyMenu(character, ship);

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            Store.BuyItem(character, planet);
        //            return true;
        //        case "2":
        //            Store.BuyItem(character, planet);
        //            return true;
        //        case "3":
        //            Store.BuyItem(character, planet);
        //            return true;
        //        case "4":
        //            Store.BuyItem(character, planet);
        //            return true;
        //        case "5":
        //            Graphics.ShoppingMainMenu(character, ship);
        //            return true;
        //        case "6":
        //            MainMenu(character, ship, planet);
        //            return true;
        //        default:
        //            return true;
        //    }
        //}

        //public static bool ShoppingSellMenu(Character character, Ship ship, Planet planet)
        //{
        //    Console.Clear();
        //    Graphics.ShoppingBuyMenu(character, ship);

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            Store.SellItem(character, planet);
        //            return true;
        //        case "2":
        //            Store.SellItem();
        //            return true;
        //        case "3":
        //            Store.SellItem();
        //            return true;
        //        case "4":
        //            Store.SellItem();
        //            return true;
        //        case "5":
        //            Graphics.ShoppingMainMenu(character, ship);
        //            return true;
        //        case "6":
        //            MainMenu(character, ship, planet);
        //            return true;
        //        default:
        //            return true;
        //    }
        //}
    }
}