public class StationaryBike : Activity
{
    private double _speed;

    public StationaryBike(string date, int minutes, double speed) : base(date, minutes)
    {
        _activity = "Stationary Bike";
        _speed = speed;
    }

    public override double CalculateDistance()
    {   
        double distance = Math.Round(_minutes * _speed / 60, 1);
        return distance;
    }

    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(60 / _speed, 1);
        return pace;
    }
}