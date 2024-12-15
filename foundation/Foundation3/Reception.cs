public class Reception : Event
{   
    private string _email;

    public Reception(string title, string description, string date, string time, string type, Address address, string email) : base (title, description, date, time, type, address)
    {
        _email = email;
    }

    public string GetReceptionFullDetails()
    {   
        return $"Event Type: {base.GetEventType()}\n{base.GetStandardDetails()}\nRSVP: {_email}";
    }
}