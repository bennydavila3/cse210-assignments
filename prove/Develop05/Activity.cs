using System;
using System.Diagnostics;
public class Activity
{
    private string _name;
    private string _description;
    private int _timer;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _timer = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get Ready...");
        Animation(5);
        Console.WriteLine();
    }
    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {_timer} seconds of the {_name} Activity.");
    }
    public void Animation(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public int GetTimer()
    {
        return _timer;
    }
    public void Countdown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}