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
                    exitGame();
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
                    TravelToEarth();
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
                    Graphics.TravelMenu();
                    return true;
                case "2":
                    Graphics.ShoppingMainMenu();
                    return true;
                case "3":
                    Graphics.ShoppingMainMenu();
                    return true;
                case "4":
                    exitGame();
                    return false;
                default:
                    return true;
            }
        }

        public bool ShoppingBuyMneu()
        {
            Console.Clear();
            Graphics.ShoppingBuyMenu();
            Graphics.HeadsUpDisplay();

            switch (Console.ReadLine())
            {
                case "1":
                    BuyResource1();
                    return true;
                case "2":
                    BuyResource2();
                    return true;
                case "3":
                    BuyResource3();
                    return true;
                case "4":
                    BuyFuel();
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