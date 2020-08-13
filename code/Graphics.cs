using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceGame
{
    public class Graphics
    {
        public static void SplashScreen()
        {
            //Font courtesy of ascii.co.uk
            Console.SetWindowSize(120, 60);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(@"
        ///////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                           //
        //                                     © Space Force 1                                       //
        //                               ---> Ludicrous speed!! <---                                 //
        //                                                                                           //
        ///////////////////////////////////////////////////////////////////////////////////////////////
            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MainMenu(Character character, Ship ship)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
***********************************************************************************************
**                                                                                           **
**                                                                                           **
**                                       LOST IN SPACE!                                      **
**                                                                                           **
**          The year is 2020, the Earth is in shambles! One young Space Captain has          **
**          heard of an opportunity to escape this dying planet, and even this whole         **
**          galaxy! Elon Musk has created a utopia, referred to only as ArkX, which          **
**          anyone can find refuge in. But only if they can afford a ticket to               **
**          another galaxy! So, young Captain Kirk sets out to build his fortune, and        **
**          purchase the last ticket to ArkX left on Earth!                                  **
**                                                                                           **
**                            1. Travel to a new planet                                      **
**                            2. Shop resources                                              **
**                            3. Buy fuel                                                    **
**                            4. Exit game                                                   **
**                                                                                           **
***********************************************************************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            HeadsUpDisplay(character, ship);
        }

        public static void TravelMenu(Character character, Ship ship)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
***********************************************************************************************
**                                                                                           **
**          Different planets offer different prices on goods! Trade goods between planets   **
**          to build your fortune!                                                           **
**                                                                                           **
**                            SELECT A PLANET TO TRAVEL TO                                   **
**                                                                                           **
**                                                        Travel time:                       **
**                            1. Earth                                                       **
**                            2. Alpha Proxima                                               **
**                            3. Exandria                                                    **
**                            4. Midgard                                                     **
**                            5. MiddleEarth                                                 **
**                            6. Return to main menu                                         **
**                                                                                           **
***********************************************************************************************");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            HeadsUpDisplay(character, ship);
        }
        public static void ShoppingMainMenu(Character character, Ship ship)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                         SHOP MENU                                         //
//                                                                                           //
//                            1. Buy resources or fuel                                       //
//                            2. Sell resources                                              //
//                            3. Return to main menu                                         //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShoppingBuyMenu(Character character, Ship ship)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                              SELECT A RESOURCE TO PURCHASE                                //
//                                                                                           //
//                                                   Resource cost per unit:                 //
//                            1. Resource 1                                                  //
//                            2. resource 2                                                  //
//                            3. resource 3                                                  //
//                            4. fuel                                                        // 
//                            5. Return to shopping menu                                     // 
//                            6. Return to main menu                                         //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            HeadsUpDisplay(character, ship);
        }

        public static void HeadsUpDisplay(Character C, Ship S)
        {
            string border = "**";
            string age = $"Age:    {C.age}";
            string fuel = $"Fuel: {C.fuel}";
            string water = $"Water:  {C.water}";
            string money = $"Money:  {C.totalMoney}";
            string load = $"Load: {C.totalWeight}";
            string gold = $"Gold:   {C.gold}";
            string planet = $"Planet: {S.currentPlanet.planetName}";
            string oxygen = $"Oxygen: {C.oxygen}";
            Console.WriteLine(@$"
**___________________________________________________________________________________________**
**                                                                                           **
**        | {C.name} |                 | USS Enterprise |               | Cargo |        **
**___________________________________________________________________________________________**
**                                                                                           **");
            //Console.Write("{0, 0}{0, 5}{0, 35}{0, 70}(0, 100}",
            //    border [0], age[1], fuel[2], water[3], border[4]);

            Console.Write(border);
            Console.Write(age.PadRight(5));
            Console.Write(fuel.PadLeft(40));
            Console.Write(water.PadLeft(33));
            Console.WriteLine(border.PadLeft(10));
            Console.Write(border);
            Console.Write(money.PadLeft(5));
            Console.Write(load.PadLeft(35));
            Console.Write(gold.PadLeft(34));
            Console.WriteLine(border.PadLeft(10));
            Console.Write(border);
            Console.Write(planet.PadLeft(5));
            Console.Write(oxygen.PadLeft(70));
            Console.Write(border.PadLeft(10));
            Console.Write(@$"
**                                                                                           **
***********************************************************************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("Make a menu selection: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


