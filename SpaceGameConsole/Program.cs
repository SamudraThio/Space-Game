using System;
using SpaceGame;
namespace SpaceGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartGame.Run(); 
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                //ProgramExit();
            }
        }
    }
}
