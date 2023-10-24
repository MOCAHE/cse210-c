using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nType: Reception\nEmail for RSVP: {_email}";
    }

    public override string ShortDescription()
    {
        return $"Event: Reception\n{base.ShortDescription()}";
    }
}