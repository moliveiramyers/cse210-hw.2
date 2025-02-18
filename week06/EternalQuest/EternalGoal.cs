using System;

public class EternalGoal: Goal
{
    public EternalGoal(string shortName, string description, int points): base(shortName,description,points)
    {

    }
    public override void RecordEvent()
    {
       _totalPoints += GetPoints(); 

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal${GetShortName()}${GetDescription()}${GetPoints()}${GetTotalPoints()}";
    }
    

}