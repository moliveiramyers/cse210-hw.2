using System;

public  class Square : Shapes
{
    private double _side;
    public Square(string coulor, double side) : base(coulor)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side*_side;
    }

}