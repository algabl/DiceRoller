using System;

namespace DiceRoller
{
    public class Roll
    {
        public void SimulateRolls(int temp)
        {
            Random ran = new Random();
            int[] results = new int[11];
            for (int i = 0; i < temp; i++)
            {
                int dieOne = ran.Next(1, 7);
                int dieTwo = ran.Next(1, 7);
                int total = dieOne + dieTwo;
                results[total - 2]++;
            }
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = {0}.", temp);
            Console.WriteLine();

            double singleResult;
            double percent;
            for (int i = 0; i < results.Length; i++)
            {
                singleResult = results[i];
                percent = (singleResult / temp) * 100;
                percent = Math.Round(percent);
                Console.Write("{0}: ", i + 2);
                for (int x = 0; x < percent; x++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}