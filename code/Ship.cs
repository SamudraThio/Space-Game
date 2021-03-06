using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SpaceGame
{
    public class Ship
    {
        // Will track fuel and fuel capacity
        public Planet currentPlanet = Planet.Earth();  //Will Track current location of the ship
        public Planet newPlanet;
        public double time;

        public double Distance(Planet newPlanet)
        {
            //Pulls distance using coordinates of the current planet and new planet

            double x1 = currentPlanet.xcoord;
            double y1 = currentPlanet.ycoord;
            double x2 = newPlanet.xcoord;
            double y2 = newPlanet.ycoord;

            double findx = Math.Pow(x2 - x1, 2);
            double findy = Math.Pow(y2 - y1, 2);

            double distance = Math.Sqrt(findx + findy);

            return distance;
        }

        public Planet Travel(Character character, Planet newPlanet)
        {
            //Takes input of newPlanet, asks for user input for fuel level, converts to warpLevel, warpLevel feeds into warpSpeed,
            //distance and warpSpeed give us out time metric in light years

            var distance = Distance(newPlanet);

            bool done = false;

            while (!done)
            {
                Console.WriteLine("How much fuel would you like to load? \n (Enter a number 1-9)");

                string warpInput = Console.ReadLine();
                int warpLevel = int.Parse(warpInput);

                //TODO: Try and catch block? why wont TryParse work?
                if (warpLevel > 0 && warpLevel < 10)
                {

                    double firstWarpValue = Math.Pow(warpLevel, 10.0 / 3.0);
                    double secondWarpValue = Math.Pow(10 - warpLevel, -11.0 / 3.0);

                    double warpSpeed = firstWarpValue + secondWarpValue;

                    if (character.fuel - warpLevel < 0)
                    {
                        Console.WriteLine("We don't have that much fuel, Captain!");
                    }
                    else
                    {
                        SubtractFuel(warpLevel, character);

                        TimePassed(character, distance, warpSpeed);

                        done = true;
                    }
                }

                else
                {
                    Console.WriteLine("Captain, we can only use between 1 and 9 units of fuel, or we'll never make it!");
                }
            }

            return ShiftPlanet(newPlanet);
        }

        public double TimePassed(Character character, double distance, double warpSpeed)
        {
            double time = Math.Round(distance / warpSpeed, 2);
            character.age += time;

            if (character.age >= 60)
            {
                Console.WriteLine("You have reached 60 years of age, Captain. Your body can no longer withstand the rigors of space travel!");
                Console.ReadLine();
                ExitGame.exitGame();
            }

            return time;
        }

        private Planet ShiftPlanet(Planet newPlanet)
        {
            currentPlanet = newPlanet;
            return currentPlanet;
        }

        public int SubtractFuel(int warpLevel, Character character)
        {
            character.fuel -= warpLevel;

            return character.fuel;
        }

        public int AddFuel(Character character)
        {
            if (character.fuel < Character.fuelCapacity)
            {
                character.fuel++;
                return character.fuel;
            }
            else
            {
                Console.WriteLine("Sir, our fuel is at maximum capacity!");
                return character.fuel;
            }
        }
    }
}
