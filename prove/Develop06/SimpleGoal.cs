public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isCompleted, int goalType) : base(name, description, points, isCompleted, goalType){}

    public override string GetGoalInfo()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_isCompleted}";
    }

    public override void MarkComplete()
    {
        _isCompleted = true;
        Console.WriteLine($"You earned {_points} points!");
    }
    public override void DisplayGoal()
    {
        string status = " ";
        if(_isCompleted)
        {
            status = "X";
        }
        Console.WriteLine($"[{status}] {_name}: {_description}");
    }
}