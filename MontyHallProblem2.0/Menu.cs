using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem2._0
{
    internal class Menu
    {
   
        internal static int ChooseNumberOfDoors()
        {
            int noOfDoors;
            do
            {
                Console.WriteLine("\nHow many doors do you whant? (at least two doors)\n");
                int.TryParse(Console.ReadLine(), out noOfDoors);
            } while (noOfDoors < 2 || noOfDoors > 10_000_000);
            return noOfDoors;
        }

        internal static int ChooseNumberOfSimulations()
        {
            int noOfSimulations;
            do
            {
                Console.WriteLine("\nHow many simulations do you whant to do? (Tips: Go high and simulat at least 10000 games for higher accuracy)\n");
                int.TryParse(Console.ReadLine(), out noOfSimulations);
            } while (noOfSimulations <= 0 || noOfSimulations > 10_000_000);
            return noOfSimulations;
        }

        internal static bool ChangeOrKeepDoor()
        {
            bool isRunning = true;
            bool? KeepDoor = null;

            do
            {
                Console.WriteLine("Choose if you whant to change or keep the door\n");
                Console.WriteLine("[1] Change door");
                Console.WriteLine("[2] Keep door\n");
                int.TryParse(Console.ReadLine(), out int changeOrKeep);

                if (changeOrKeep == 1)
                {
                    KeepDoor = false;
                    isRunning = false;
                }
                else if (changeOrKeep == 2)
                {
                    KeepDoor = true;
                    isRunning = false;
                }
            } while (isRunning);

            return (bool)KeepDoor;
        }

        internal static void EndMessage(int noOfDoors, int noOfSimulations, int winningGames, double winnings)
        {
            Console.Clear();
            Console.WriteLine($"New car owners: {winningGames}\n");
            Console.WriteLine($"Attempts: {noOfSimulations}\n");
            Console.WriteLine($"Doors in game: {noOfDoors}\n");
            Console.WriteLine($"Winning accuracy: {winnings}%\n");
            Console.WriteLine("Press any key to try again");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
