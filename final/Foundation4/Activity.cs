using System;
using System.Collections.Generic;
using System.Globalization;


public abstract class Activity
{
    protected DateTime _date;
    protected double _activityLength;

    public Activity(DateTime date, double activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return GetDistance() / (_activityLength / 60);
    }

    public virtual double GetPace()
    {
        return _activityLength / GetDistance();
    }

    public virtual string GetSummary()
    {
        CultureInfo cultureInfo = new CultureInfo("en-US");
        return $"{_date.ToString("dd MMM yyyy", new CultureInfo("en-US"))}\n{GetType().Name} ({_activityLength} min)\nDistance {GetDistance():0.0} km\nSpeed: {GetSpeed():0.0} km/h\nPace: {GetPace():0.0} min per km";
    }
}