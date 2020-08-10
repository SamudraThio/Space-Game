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

                Character character = new Character();
                Ship ship = new Ship();

                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = Menu.MainMenu(character, ship);
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