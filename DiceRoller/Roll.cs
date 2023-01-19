using System;

namespace DiceRoller
{
    public class Roll
    {
        // Method for simulating the rolls
        public void SimulateRolls(int rollNum)
        {
            Random ran = new Random();
            
            int[] results = new int[11];
            
            // Run the simulation of rolling dice and store the results
            for (int i = 0; i < rollNum; i++)
            {
                int dieOne = ran.Next(6);
                int dieTwo = ran.Next(6);
                int total = dieOne + dieTwo;
                results[total]++; // Location 0 in the array stores the rolls for 2, and so on 
            }
            
            //Output the results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = {0}.", rollNum);
            Console.WriteLine();
            // Calculates the percentage of each result
            double singleResult;
            double percent;
            for (int i = 0; i < results.Length; i++)
            {
                singleResult = results[i];
                percent = (singleResult / rollNum) * 100;
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