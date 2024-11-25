using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        bool run = true;
        while(run)
        {
            DisplayMenu(goalTracker);
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch(choice)
            {
                case 1: //new goal
                goalTracker.CreateNewGoal();
                break;

                case 2: //list goals
                goalTracker.ListGoals();    
                break;
                
                case 3: //save goals
                goalTracker.SaveGoals();    
                break;

                case 4: // load goals
                goalTracker.LoadGoals();    
                break;

                case 5: // record event
                goalTracker.RecordEvent();    
                break;

                case 6: // quit program
                run = false;
                break;
            }
        }
    }
    static void DisplayMenu(GoalTracker goalTracker)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {goalTracker.GetTotalPoints()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}