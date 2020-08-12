﻿using System;
using SpaceGame;

namespace SpaceGame
{
    public class StartGame
    
    {
        internal double age;

        public static void Run()
        {
            try
            {
                Graphics.SplashScreen();

                Character character = new Character();
                Ship ship = new Ship();
                Planet planet = new Planet();
                Store store = new Store();

                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = Menu.MainMenu(character, ship, planet);
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