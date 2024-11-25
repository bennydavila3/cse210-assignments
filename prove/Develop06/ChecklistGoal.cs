public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesRequired;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool isCompleted, int timesCompleted, int timesRequired, int bonusPoints, int goalType) : base(name, description, points, isCompleted, goalType)
    {
        _timesRequired = timesRequired;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }
    public override void MarkComplete()
    {
        if (_timesCompleted < _timesRequired)
        {
            _timesCompleted++;
            Console.WriteLine($"You earned {_points} points for completing part of '{_name}'!");
        }
        if (_timesCompleted == _timesRequired)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You earned {_bonusPoints} bonus points for completing '{_name}'!");
        }
    }
    public override string GetGoalInfo()
    {
        return $"{_goalType}|{_name}|{_description}|{_points}|{_isCompleted}|{_timesCompleted}|{_timesRequired}|{_bonusPoints}";
    }
    public override void DisplayGoal()
    {
        string status = " ";
        if(_isCompleted)
        {
            status = "X";
        }
        Console.WriteLine($"[{status}] {_name}: {_description} - {_timesCompleted}/{_timesRequired} completed");
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}