using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem2._0
{
    internal class Game
    {

        internal static int MontyHallGame(int noOfDoors, int noOfSimulations, int changeOrKeep)
        {
            Random random = new Random();
            int winningGames = 0;

            for (int i = 0; i < noOfSimulations; i++)
            {

                var PrizeDoor = random.Next(0, noOfDoors);

                var ChosenDoor = random.Next(0, noOfDoors);

                if (changeOrKeep == 1)
                {
                    if (PrizeDoor != ChosenDoor)
                    {
                        winningGames++;
                    }
                }

                if (changeOrKeep == 2)
                {
                    if (PrizeDoor == ChosenDoor)
                    {
                        winningGames++;
                    }
                }
            }

            return winningGames;
        }
    }
}
