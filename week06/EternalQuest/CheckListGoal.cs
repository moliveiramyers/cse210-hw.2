using System;

public class CheckListGoal: Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus): base(shortName,description,points)
    {
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted ++;

            _totalPoints += GetPoints();
        
            if(_amountCompleted ==  _target)
            {
                _totalPoints += _bonus;
                Console.WriteLine($"Bonus of {_bonus} points Addes");
            }

            Console.WriteLine($" You already did {_amountCompleted}/{_target}");
        }
        else
        {
            Console.WriteLine("You Already completed this goal");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString() 
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        return $". {checkBox} {GetShortName()} ({GetDescription()}) --- {_amountCompleted}/{_target}.";
        
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal${GetShortName()}${GetDescription()}${GetPoints()}${_amountCompleted}${_target}${_bonus}${GetTotalPoints()}";
    }
    
    public override void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}