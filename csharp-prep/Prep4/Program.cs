using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string textNumber = Console.ReadLine();
            userNumber = int.Parse(textNumber);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // calculate sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // compute average
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find max number
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            max = number;
        }
        Console.WriteLine($"The max is: {max}");

    }
}