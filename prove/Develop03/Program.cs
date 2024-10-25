using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("John", "3", "16");
        // Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.WriteLine("Welcome to Scripture Memorizer! We will help you memorize the scripture you want, we just need the following deatils.");

        Console.Write("Enter Book Name: ");
        string book = Console.ReadLine();

        Console.Write("Enter Chapter: ");
        string chapter = Console.ReadLine();

        Console.Write("Enter first verse: ");
        string verseStart = Console.ReadLine();

        Console.Write("Enter last verse: ");
        string verseEnd = Console.ReadLine();

        Console.WriteLine("Type in the verse: ");
        string scriptureText = Console.ReadLine();

        //build reference
        Reference reference = new Reference(book, chapter, verseStart, verseEnd);
        Scripture scripture = new Scripture(reference, scriptureText);

        string choice = "";

        while (choice != "quit")
        {
            Console.Clear(); // Clears console
            Console.WriteLine(scripture.GetFullScripture());

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            if (scripture.AllWordsHidden())
            {
                break;
            }

            if (choice != "quit")
            {
                scripture.HideRandomWord();
                scripture.HideRandomWord();
                scripture.HideRandomWord();
            }
        }
    }
}
