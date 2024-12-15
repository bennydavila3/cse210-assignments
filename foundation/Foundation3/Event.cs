public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _eventType;
    private Address _address;

    public Event(string title, string description, string date, string time, string eventType, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate/Time: {_date} at {_time}\nAddress: {_address.GetFullAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
    public string GetEventType()
    {
        return _eventType;
    }
}