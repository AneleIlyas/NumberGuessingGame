using System;

namespace NumberGuessingGame
{
    public class Program
    {
        static void Main(string [] args)
        {
            Random random = new Random();
            int num = random.Next(0, 100);
            Console.WriteLine("Welcome: This is a number guessing game");
            Console.WriteLine("Enter -1 to quit");
            Console.WriteLine("Guess range: 0 - 100");
            Console.WriteLine("========================================");
            Console.Write("Enter your guess: ");
            int guess;
            while (true)
            {
                try 
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == -1) 
                    {
                        Console.WriteLine("Goodbye. Thanks for trying");
                        Console.WriteLine("Enter any key to finish");
                        Console.ReadKey(true);
                        break;
                    };
                    if (guess == num) 
                    {
                        Console.WriteLine($"Congragulations. You guess correctly. Random number was {num}");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"Sorry, try again. Your guess: {guess} was incorrect.");
                        if (guess > num) Console.WriteLine("You guess was too high. Guess lower.");
                        else if (guess < num) Console.WriteLine("You guess was too low. Guess higher");
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try another guess. 0 to quit.");
                    continue;
                }
            }
        }
    }
}