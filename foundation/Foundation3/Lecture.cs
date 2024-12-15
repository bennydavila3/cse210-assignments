public class Lecture : Event
{
    private string _speaker;  
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string eventType, Address address, string speaker, int capacity) : base (title, description, date, time, eventType, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectureFullDetails()
    {
        return $"Event Type: {base.GetEventType()}\n{base.GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}