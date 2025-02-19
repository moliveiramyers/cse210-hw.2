using System;

public class Swimming : Activity
{
    private double _numberLaps;

    public Swimming( string date, double length, double numberLaps) : base(date, length)
    {
        _numberLaps = numberLaps;
        SetName("Swimming");
    }

    public override double Distance()
    {
        return _numberLaps * 50/1000;
    }

    public override double Speed()
    {
        return Distance()/GetLength() * 60;
    }

    public override double Pace()
    {
        return GetLength()/Distance();
    }
}