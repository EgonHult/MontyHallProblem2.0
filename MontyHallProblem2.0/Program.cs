using System;

namespace MontyHallProblem2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello, and welcome to The Monty Hall Game 2.0!!!");

            while (true)
            {
                int noOfDoors;
                do
                {
                    Console.WriteLine("\nHow many doors do you whant?\n");
                    int.TryParse(Console.ReadLine(), out noOfDoors);
                } while (noOfDoors <= 1 || noOfDoors > 10_000_000);


                int noOfSimulations;
                do
                {
                    Console.WriteLine("\nHow many simulations do you whant to do? (Tips: Go high and simulat at least 10000 games for higher accuracy)\n");
                    int.TryParse(Console.ReadLine(), out noOfSimulations);
                } while (noOfSimulations <= 0 || noOfDoors > 10_000_000);

                bool isRunning = true;
                int changeOrKeep = 0;

                while (isRunning)
                {
                    Console.WriteLine("Choose if you whant to change or keep the door\n");
                    Console.WriteLine("[1] Change door");
                    Console.WriteLine("[2] Keep door\n");
                    int.TryParse(Console.ReadLine(), out changeOrKeep);

                    if (changeOrKeep == 1 || changeOrKeep == 2)
                        isRunning = false;
                }

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

                var winnings = CalculateNumberOfWinsToPercent(winningGames, noOfSimulations);

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

        private static double CalculateNumberOfWinsToPercent(int winningGames, int noOfSimulations)
        {
            if (noOfSimulations <= 0)
                throw new Exception("You can't divide something with zero and we won't let you set the dividor to a negative number");

            double winningpercentage = (winningGames / (double)noOfSimulations) * 100;

            return Math.Round(winningpercentage, 6);
        }
    }
}
