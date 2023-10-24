using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}