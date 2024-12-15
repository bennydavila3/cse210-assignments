public class OutdoorGathering : Event
{   
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, string eventType, Address address, string weather) : base (title, description, date, time, eventType, address)
    {
        _weather = weather;
    }

    public string GetWeatherStatement()
    {
        return $"The weather will be {_weather}.";
    }

    public string GetOutdoorGatheringFullDetails()
    {   
        return $"Event Type: {base.GetEventType()}\n{base.GetStandardDetails()}\nWeather Statement: {GetWeatherStatement()}";
    }
}