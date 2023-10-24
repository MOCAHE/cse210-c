using System;

public class Lectures : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int maxCapacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_maxCapacity}";
    }

    public override string ShortDescription()
    {
        return $"Event: Lecture\n{base.ShortDescription()}";
    }
}