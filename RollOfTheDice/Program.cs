/* 
Hunter Clezie 
Spring 2026
RCET2265
RollOfTheDice
github url: https://github.com/hunterclezie-pixel/RollOfTheDice.git
*/
using System.ComponentModel.DataAnnotations.Schema;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace RollOfTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //Constructor
            int[] rolls = new int[13]; // Array to count occurrences of each possible roll (2-12)
            string columnSeperator = "|"; // String to separate columns in the output

            Console.WriteLine("Roll Of The Dice");

            for (int i = 0; i < 1000; i++)
            {
                int n = rand.Next(2, 12 + 1); // Random number between 2 and 12
                rolls[n]++; // Increment the count for this roll
            }

            // Print the results:
            // First line is the numbers 2-12
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}".PadRight(4) + columnSeperator);
            }
            Console.WriteLine();

            // Second line is the number of times each number was rolled
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{rolls[i]}".PadRight(4) + columnSeperator);
            }
            Console.WriteLine();

            //pause
            Console.Read();
        }
    }
}
