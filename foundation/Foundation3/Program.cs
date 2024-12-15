using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        Address address1 = new Address("123 Northpoint", "Houston", "Texas", "USA");
        Lecture lecture = new Lecture("Game of Soccer", "Learn the tactics of having a ball at your feet", "December 15, 2024", "8pm", "Lecture", address1, "Benny", 180);

        Console.WriteLine("Event 1:");
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetLectureFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("--------------------------------------------------------------------------------");
        Address address2 = new Address("345 Cedars", "Miami", "Florida", "USA");
        Reception reception = new Reception("The Big Wedding", "Selena Gomez and Benny Blanco get Married", "August 17, 2025", "6:30pm", "Reception", address2, "justinbieber@idk.com");

        Console.WriteLine("Event 2:");
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetReceptionFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("--------------------------------------------------------------------------------");
        Address address3 = new Address("789 The Cove", "Las Vegas", "Nevada", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("The Famous Horsemen", "Meet the famous Horsemen at your favorite casino", "July 7, 2028", "8pm", "Outdoor Gathering", address3, "Rainy");

        Console.WriteLine("Event 3:");
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}