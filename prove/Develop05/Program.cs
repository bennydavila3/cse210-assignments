using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the MINDFULNESS APP!");

        bool run = true;
        while(run)
        {
            MenuDisplay();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch(choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartMessage();
                    breathing.PerformActivity();
                    breathing.EndMessage();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.StartMessage();
                    reflection.PerformActivity();
                    reflection.EndMessage();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.StartMessage();
                    listing.PerformActivity();
                    listing.EndMessage();
                    break;

                case "4":
                    run = false;
                    Console.WriteLine("Thank You!");
                    break;

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
    public static void MenuDisplay()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Brething Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }
}