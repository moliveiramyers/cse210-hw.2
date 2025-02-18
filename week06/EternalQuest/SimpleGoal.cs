using System;
using System.Reflection.Metadata;

public class SimpleGoal: Goal
{
    private bool _isComplete; 
    public SimpleGoal(string shortName, string description, int points): base(shortName, description, points)
    {
        _isComplete = false;

    }
    public override void RecordEvent()
    {
        _isComplete = true; 
        SetTotalPoints(GetPoints());       
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkBox = _isComplete ? "[X]" : "[ ]";
        return $". {checkBox} {GetShortName()} ({GetDescription()}).";
    }
    
    public override string GetStringRepresentation()
    {
        return $"Simple Goal${GetShortName()}${GetDescription()}${GetPoints()}${GetTotalPoints()}";        

    }
    public override void SetTotalPoints(int points)
    {
        _totalPoints = points;
        if(_totalPoints > 0)
        {
            _isComplete = true;
        }
    }

}