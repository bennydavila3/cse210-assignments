using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
    }
    public void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTimer());
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("Breathe in...");
            Countdown(4);
            Console.WriteLine();
            Console.Write("Breathe Out...");
            Countdown(6);
            Console.WriteLine();

            currentTime = DateTime.Now;
        }
    }
}