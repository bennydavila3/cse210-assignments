using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        // determine letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else (percent < 60)
        {
            letter = "F";
        }

        // print letter grade
        Console.WriteLine(letter);

        // pass or no pass
        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You passed.");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}