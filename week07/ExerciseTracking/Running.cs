using System;

public class Running : Activity
{
    private double _distance;

    public Running( string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
        SetName("Running");
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double speed = _distance/GetLength() * 60; 
        return speed;
    }

    public override double Pace()
    {
        return GetLength()/_distance;
    }
}