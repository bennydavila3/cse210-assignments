using System;

class Program
{
    static void Main(string[] args)
    {
        // random number
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,101);

        int guess = 0;

        // user guess
        while (magic != guess)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }        
        }
    }
}