using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        bool run = true;
        while (run)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry Added!");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Filename to Load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "4":
                    Console.Write("Filename to Save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "5":
                    run = false;
                    Console.WriteLine("Thank You!");
                    break;

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
    public static void DisplayMenu()
    {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
    }
}