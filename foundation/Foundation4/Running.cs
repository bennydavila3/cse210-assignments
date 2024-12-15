public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _activity = "Running";
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_distance, 1);
    }

    public override double CalculateSpeed()
    {
        double speed = Math.Round((_distance / _minutes) * 60, 1);
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(_minutes / _distance, 1);
        return pace;
    }
}