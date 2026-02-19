namespace RollOfTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //Constructor
            int[] rolls = new int[13]; // Array to count occurrences of each possible roll (2-12)

            Console.WriteLine("Roll Of The Dice");

            for (int i = 0; i < 1000; i++)
            {
                int n = rand.Next(2, 12 + 1); // Random number between 2 and 12
                rolls[n]++; // Increment the count for this roll
            }

            // Print the results
            for (int i = 2; i <= 12; i++)
            {
                Console.WriteLine($"Number {i} rolled {rolls[i]} times.");
            }

            //pause
            Console.Read();
        }
    }
}
