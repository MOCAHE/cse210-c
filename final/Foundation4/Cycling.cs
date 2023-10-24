using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double activityLength, double speed) : base(date, activityLength)
    {
        _speed = speed;
    }

    public override double GetDistance()//D = V x T
    {
        return _speed * (_activityLength / 60);
    }
}