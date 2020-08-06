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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("This will be the splash screen");

            /*
            Console.WriteLine(@"");
*/

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
            //TODO Program.MainMenu(); rename this to whatever our entry point will be, startgame?
        }

        public static void MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
***********************************************************************************************
**                                                                                           **
**                                       LOST IN SPACE!                                      **
**                                                                                           **
**                            1. Travel to a new planet                                      **
**                            2. Shop resources                                              **
**                            3. Buy fuel                                                    **
**                            4. Exit game                                                   **
**                                                                                           **
***********************************************************************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            HeadsUpDisplay();
        }

        public static void TravelMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
***********************************************************************************************
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
            HeadsUpDisplay();
        }

        public static void ShoppingMainMenu()
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

        public static void ShoppingBuyMenu()
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
            HeadsUpDisplay();
        }

        //TODO implement shopping buy submenu where user can enter number of units to purchase.

        public static void HeadsUpDisplay()
        {Console.WriteLine(@$"
**___________________________________________________________________________________________**
**                                                                                           **
**     | Captain Kirk |           | USS Enterprise |        | Cargo |                        **
**___________________________________________________________________________________________**
**                                                                                           **
**       Age:    18                 Fuel: 10/10              Water:  3                       **
**       Money:  $1,000,000         Load: 10/10              Gold:   2                       **
**       Planet: Earth                                       Oxygen: 5                       **
**                                                                                           **
***********************************************************************************************");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("Make a menu selection: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


