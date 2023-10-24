using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double activityLength, int laps) : base(date, activityLength)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }
}