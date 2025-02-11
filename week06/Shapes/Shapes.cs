using System;

public abstract class Shapes
{
    private string _coulor;
    public Shapes( string coulor)
    {
     _coulor = coulor;
    }
    public string GetCoulor()
    {
        return _coulor;
    }

    public void SetCoulor(string coulor)
    {
        _coulor = coulor;
    }

    public abstract double GetArea();

}