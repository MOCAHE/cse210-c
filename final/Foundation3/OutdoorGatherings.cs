using System;

public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string title, string description, string date, string time, Address adress, string weather) : base(title, description, date, time, adress)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Outdoor Gathering\nWeather: {_weather}";
    }

    public override string ShortDescription()
    {
        return $"Event: Outdoor Gathering\n{base.ShortDescription()}";
    }
}