using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SpaceGame
{
    //TODO resolve red squigley's in Ship

    public class Ship
    {
        public int fuel = 10; // Will track fuel and fuel capacity
        public Character Character;
        public Planet currentPlanet = Planet.Earth();  //Will Track current location of the ship
        public double distance; //Between currentPlanet and newPlanet

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

        public Planet Travel(Planet newPlanet)
        {
            //Takes input of newPlanet, asks for user input for fuel level, converts to warpLevel, warpLevel feeds into warpSpeed,
            //distance and warpSpeed give us out time metric in light years

            Console.WriteLine("How much fuel would you like to load? \n (Enter a number 1-9)");

            string warpInput = Console.ReadLine();
            int warpLevel = int.Parse(warpInput);

            //TODO: Try and catch block? why wont TryParse work?

            if (warpLevel > 0 && warpLevel < 10)
            {

                double firstWarpValue = Math.Pow(warpLevel, 10.0 / 3.0);
                double secondWarpValue = Math.Pow(10 - warpLevel, -11.0 / 3.0);

                double warpSpeed = firstWarpValue + secondWarpValue;

                SubtractFuel(warpLevel);
                
                TimePassed(distance, warpSpeed);
            }

            else
            {
                Console.WriteLine("Captain, we can only use between 1 and 9 units of fuel, or we'll never make it!");
                Travel(newPlanet);
            }

            return ShiftPlanet(newPlanet);
        }

        public double TimePassed(double distance, double warpSpeed)
        {
            //Determine how to pass age into TimePassed
            
            double time = Math.Round( distance / warpSpeed, 2);
            Character.age += time;

            return time;
        }

        private Planet ShiftPlanet(Planet newPlanet)
        {
            currentPlanet = newPlanet;
            return currentPlanet;
        }

        public int SubtractFuel(int warpLevel)
        {
            this.fuel -= warpLevel;
            return fuel;
        }

        public int AdjustFuel(int fuel)
        {
            this.fuel += fuel;
            return fuel;
        }   
    }
}
