using System;
using Space_Game;

namespace StartGame
{
    public class StartGame
    
    {
        static void Run()
        {
            try
            {
                Graphics.SplashScreen();
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = MainMenu.mainMenu();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                //SignOff();
            }
        }
    }
}