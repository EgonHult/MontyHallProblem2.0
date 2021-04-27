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
                int changeOrKeep = ChangeOrKeepDoor();

                int winningGames = Game.MontyHallGame(noOfDoors, noOfSimulations, changeOrKeep);
                var winnings = Helpers.CalculateNumberOfWinsToPercent(winningGames, noOfSimulations);

                EndMessage(noOfDoors, noOfSimulations, winningGames, winnings);
            }
        }
    }
}
