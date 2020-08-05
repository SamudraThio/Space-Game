using System;

namespace SpaceGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new StartGame.Run(); 
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
