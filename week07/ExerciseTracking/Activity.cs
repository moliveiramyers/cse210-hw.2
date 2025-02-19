using System;
using System.Dynamic;

public abstract class Activity
{
    private DateTime _date = new DateTime(2025,2,12);
    private double _lengthMin;
    
    private string _name;

    public Activity(string date, double lengthMin) 
    {
        DateTime dateParse = DateTime.Parse(date);
      //  _date = dateParse;
        _lengthMin = lengthMin;
    }

    public void SetLength(double lengthMin)
    {
        _lengthMin = lengthMin;
    }
    public double GetLength()
    {
        return _lengthMin;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public string GetDate()
    {
        string formatDate = _date.ToString("dd MMM yyyy");
        return formatDate;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract double Distance();

    public abstract double Speed(); 

    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {_name} ({_lengthMin} min) - Distance: {Distance():F2} km, Speed: {Speed():F2} kph, Pace: {Pace():F2} min per km";
    }
}