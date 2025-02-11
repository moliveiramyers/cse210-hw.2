using System;

public  class Rectangle : Shapes
{
    private double _length;
    private double _width;
    
    public Rectangle(string coulor, double length, double  width) : base(coulor)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length*_width;
    }

}