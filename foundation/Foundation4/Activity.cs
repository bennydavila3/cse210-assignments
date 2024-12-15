public abstract class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _activity;

    public Activity(string date, int minutes)
    {
        _date =date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $">{_date} {_activity} ({_minutes} min)- Distance {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}