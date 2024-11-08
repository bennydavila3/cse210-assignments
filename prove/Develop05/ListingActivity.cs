using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
    public void PerformActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTimer());
        DateTime currentTime = DateTime.Now;
        int count = 0;

        while(currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {count} items!");
    }

}