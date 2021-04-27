using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallProblem2._0
{
    internal class Helpers
    {
        internal static double CalculateNumberOfWinsToPercent(int winningGames, int noOfSimulations)
        {
            if (noOfSimulations <= 0)
                throw new Exception("You can't divide something with zero and we won't let you set the dividor to a negative number");

            double winningpercentage = (winningGames / (double)noOfSimulations) * 100;

            return Math.Round(winningpercentage, 6);
        }
    }
}
