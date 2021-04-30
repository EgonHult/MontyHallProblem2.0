using System;
using static MontyHallProblem2._0.Menu;

namespace MontyHallProblem2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello, and welcome to The Monty Hall Game 2.0!!!");

            while (true)
            {
                int noOfDoors = ChooseNumberOfDoors();
                int noOfSimulations = ChooseNumberOfSimulations();
                bool KeepDoor = ChangeOrKeepDoor();

                int winningGames = Game.MontyHallGame(noOfDoors, noOfSimulations, KeepDoor);
                var winnings = Helpers.CalculateNumberOfWinsToPercent(winningGames, noOfSimulations);

                EndMessage(noOfDoors, noOfSimulations, winningGames, winnings);
            }
        }
    }
}
