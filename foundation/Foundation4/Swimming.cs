public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

        public override double CalculateDistance()
    {
        double distance =  Math.Round(_laps * 50 / 1000 * 0.62, 1);
        return distance;
    }

    public override double CalculateSpeed()
    {
        double speed = Math.Round((CalculateDistance() / _minutes) * 60, 1);
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(_minutes / CalculateDistance(), 1);
        return pace;
    }
}