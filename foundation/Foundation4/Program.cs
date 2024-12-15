using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("May 25, 2022", 30, 3.5);
        activities.Add(running);
        StationaryBike stationaryBike = new StationaryBike("June 8, 2023", 60, 8);
        activities.Add(stationaryBike);
        Swimming swimming = new Swimming("July 9, 2024", 45, 30);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}