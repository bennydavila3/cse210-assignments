public class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal(string name, string description, int points, bool isCompleted,int timesCompleted, int goalType) : base(name, description, points, isCompleted, goalType)
    {
        _timesCompleted = timesCompleted;
    }
    public override void MarkComplete()
    {
        _timesCompleted += 1;
        Console.WriteLine($"You earned {_points} points for progressing!");
    }
    public override string GetGoalInfo()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_isCompleted}|{_timesCompleted}";
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name}: {_description} - (Completed: {_timesCompleted} times)");
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
}