using System;
using SpaceGame;

namespace SpaceGame
{
    public class StartGame
    
    {
        public static void Run()
        {
            try
            {
                Graphics.SplashScreen();
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = Menu.MainMenu();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                ExitGame.exitGame();
            }
        }
    }
}