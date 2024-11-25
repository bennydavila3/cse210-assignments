public class GoalTracker
{
    private int _totalPoints;
    private List<Goal> _goals = new List<Goal>();

    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
                    
        switch(goalType)
        {
            case 1:
            SimpleGoal newSimple = new SimpleGoal(name, description, points, false, 1);
            _goals.Add(newSimple);
            break;

            case 2:
            EternalGoal newEternal = new EternalGoal(name, description, points, false, 0, 2);
            _goals.Add(newEternal);
            break;

            case 3:
            Console.Write("How many times do you need to complete this goal? ");
            int timesRequired = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points once fully completed? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal newChecklist = new ChecklistGoal(name, description, points, false, 0, timesRequired, bonusPoints, 3);
            _goals.Add(newChecklist);
            break;
        }
    }
    public int GetTotalPoints()
    {
        _totalPoints = 0;
        foreach (Goal goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                _totalPoints += checklistGoal.GetPoints() * checklistGoal.GetTimesCompleted();
                if (checklistGoal.GetIsCompleted())
                {
                    _totalPoints += checklistGoal.GetBonusPoints();
                }
            }
            else if (goal is EternalGoal eternalGoal)
            {
                _totalPoints += eternalGoal.GetPoints() * eternalGoal.GetTimesCompleted();
            }
            else if (goal.GetIsCompleted())
            {
                _totalPoints += goal.GetPoints();
            }
        }
        return _totalPoints;
    }
    public void ListGoals()
    {
        Console.WriteLine("Listing All Goals: ");
        foreach(Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetGoalInfo());
            }
        }
        Console.WriteLine("Goals have been saved.");
    }
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load your goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|'); 

                int goalType = int.Parse(parts[0]); 
                string name = parts[1];              
                string description = parts[2];       
                int points = int.Parse(parts[3]);    
                bool isCompleted = bool.Parse(parts[4]); 

                Goal goal = null;

                switch (goalType)
                {
                    case 1: // Simple Goal
                    goal = new SimpleGoal(name, description, points, isCompleted, goalType);
                    break;

                    case 2: // Eternal Goal
                    int timesCompleted = int.Parse(parts[5]); 
                    goal = new EternalGoal(name, description, points, isCompleted, timesCompleted, goalType);
                    break;

                    case 3: // Checklist Goal
                    int timesCompletedChecklist = int.Parse(parts[5]);
                    int timesRequired = int.Parse(parts[6]);
                    int bonusPoints = int.Parse(parts[7]);
                    goal = new ChecklistGoal(name, description, points, isCompleted, timesCompletedChecklist, timesRequired, bonusPoints, goalType);
                    break;
                }
                _goals.Add(goal);
            }
            Console.WriteLine("Goals have been loaded from the file.");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
        Console.Write("Select a goal to record progress for: ");
        int goalChoice = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = _goals[goalChoice];
        selectedGoal.MarkComplete();  
        Console.WriteLine("Goal has been updated.");
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}