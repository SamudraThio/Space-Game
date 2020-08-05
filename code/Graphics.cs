using System;
using System.Text;

namespace Space_Game
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
            /*
            Console.WriteLine(@"

     .  . '    .                                             
      '   .            . '            .                +           
              `                          '    . '
        .                         ,'`.                         .
   .                  .."    _.-;'    `.              .    
              _.-"`.##%"_.--" ,'        `.           "#"     ___,,od000
           ,'"-_ _.-.--"\   ,'            `-_       '%#%',,/////00000HH
         ,'     |_.'     )`/-     __..--""`-_`-._    J L/////00000HHHHM
 . +   ,'   _.-"        / /   _-""           `-._`-_/___\///0000HHHHMMM
     .'_.-""      '    :_/_.-'                 _,`-/__V__\0000HHHHHMMMM
 . _-""                         .        '   _,////\  |  /000HHHHHMMMMM
_-"   .       '  +  .              .        ,//////0\ | /00HHHHHHHMMMMM
       `                                   ,//////000\|/00HHHHHHHMMMMMM
.             '       .  ' .   .       '  ,//////00000|00HHHHHHHHMMMMMM
     .             .    .    '           ,//////000000|00HHHHHHHMMMMMMM
                  .  '      .       .   ,///////000000|0HHHHHHHHMMMMMMM
  '             '        .    '         ///////000000000HHHHHHHHMMMMMMM
                    +  .  . '    .     ,///////000000000HHHHHHHMMMMMMMM
     '      .              '   .       ///////000000000HHHHHHHHMMMMMMMM
   '                  . '              ///////000000000HHHHHHHHMMMMMMMM
                           .   '      ,///////000000000HHHHHHHHMMMMMMMM
       +         .        '   .    .  ////////000000000HHHHHHHHMMMMMMhs
            ");
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
            //TODO Program.MainMenu(); rename this to whatever our entry point will be
        }

        public static void MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                       LOST IN SPACE!                                      //
//                                                                                           //
//                            1. Travel to a new planet                                      //
//                            2. Shop resources                                              //
//                            3. Buy fuel                                                    //
//                            4. Exit game                                                   //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void TravelMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                            SELECT A PLANET TO TRAVEL TO                                   //
//                                                                                           //
//                                                        Travel time:                       //
//                            1. {Galaxy.planet1}         {travelTime}                       //
//                            2. {Galaxy.planet2}         {travelTime}                       //
//                            3. {Galaxy.planet3}         {travelTime}                       //
//                            4. {Galaxy.planet4}         {travelTime}                       //
//                            5. {Galaxy.planet5}         {travelTime}                       //
//                            6. Return to main menu                                         //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
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
//                            1. {resource1}         {resource1.cost}                        //
//                            2. {resource2}         {resource1.cost}                        //
//                            3. {resource3}         {resource1.cost}                        //
//                            4. {fuel}              {fuel.cost}                             // 
//                            5. Return to shopping menu                                     // 
//                            6. Return to main menu                                         //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        //TODO implement shopping buy submenu where user can enter number of units to purchase.

        public static void HeadsUpDisplay()
        {

            Console.WriteLine(@$"
//                                                                                           //
//       {Character.Name}, you are now {Character.Age} years young!                          //
//       You have {Character.TimeLeft} of space travel ahead of you!                         //
//                                                                                           //
//       You are currently on planet {Planet.Name}.                                          //
//                                                                                           //                                  
//       You have ${Character.Money}.                                                        //  
//                                                                                           //                                                                                
//       Your ship has {Ship.Fuel} units of fuel onboard.                                    //
//                                                                                           //
//       You currently have {water.count} units of water, {gold.count}, lbs of gold, {oxygen.count} cylinders of oxygen   //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("Make a menu selection: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


