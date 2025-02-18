using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    protected int _totalPoints = 0;
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $". [ ] {_shortName} ({_description}).";
    }

    public abstract string GetStringRepresentation();

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public string GetShortName()
    {
        return _shortName;
    }    
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }

    public virtual void SetTotalPoints(int points)
    {
        _totalPoints = points;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public virtual void SetAmountCompleted(int amountCompleted)
    {
        //_amountCompleted = amountCompleted;
    }

    public virtual int GetAmountCompleted()
    {
        return 0; // _amountCompleted;
    }
}