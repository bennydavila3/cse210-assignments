public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    protected int _goalType;

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public void SetIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetGoalType(int goalType)
    {
        _goalType = goalType;
    }
    public int GetGoalType()
    {
        return _goalType;
    }
    public abstract void MarkComplete();
    public abstract string GetGoalInfo();
    public abstract void DisplayGoal();
    public Goal(string name, string description, int points, bool isCompleted, int goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
        _goalType = goalType;
    }
}