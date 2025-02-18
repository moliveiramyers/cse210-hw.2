using System;

public class GoalManager()
{
    private List<Goal>_goals = new List<Goal>();
    private int _score = 0;
    public void Start()
    {
        int answer = 0;

        while (answer != 6)
        {
            Console.WriteLine($"   Total Score: {_score}");
            Console.WriteLine("Menu options: ");
            Console.WriteLine("  1. Create New Goal.");
            Console.WriteLine("  2. List Goals.");
            Console.WriteLine("  3. Save Goals.");
            Console.WriteLine("  4. Load Goals.");
            Console.WriteLine("  5. Record an Event.");
            Console.WriteLine("  6. Quit.");
            Console.Write("Select from the menu: ");
            try
            {
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("The types of goal are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Check List Goal");
                    int choice = int.Parse(Console.ReadLine());
                
                    if (choice == 1)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a brief description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        SimpleGoal goal1 = new SimpleGoal(name, description, points);
                        CreateGoal(goal1);
                    }
                    else if(choice == 2)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a brief description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        EternalGoal goal2 = new EternalGoal(name, description, points);
                        CreateGoal(goal2);                    
                    }
                    else if(choice == 3)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a brief description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many parts are required to fulfill this goal? ");
                        int target = int.Parse(Console.ReadLine());
                        Console.WriteLine("What will be the bonus when you fulfill your goal? ");
                        int bonus = int.Parse(Console.ReadLine());
                        CheckListGoal goal3 = new CheckListGoal(name, description, points, target, bonus);
                        CreateGoal(goal3);
                    }
                }
                else if (answer == 2)
                {
                    ListGoalName();

                }
                else if (answer == 3)
                {
                    Console.Write("What is the file name you wanto to save it? ");
                    string file = Console.ReadLine();
                    SaveGoals(file);
                    Loading();
                }
                else if (answer == 4)
                {
                    Console.Write("What is the file name? ");
                    string file = Console.ReadLine();
                    LoadGoals(file);
                    Loading();
                }
                else if (answer == 5)
                {
                    Console.WriteLine("What is the goal number you want to record an event: ");
                    int goal = int.Parse(Console.ReadLine());
                    RecordEvent(goal);
                    //Loading();

                }
                else if (answer == 6)
                {
                    Console.WriteLine("Bye");
                }
            
            }
            catch (FormatException)
            {
                Console.WriteLine($" This is an invalid option");
            }        
        }
    }
    public int DisplayPlayerInfo()
    {
        return _score;
    }

    public void ListGoalName()
    {
        int itemIndex = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{itemIndex}{goal.GetDetailsString()}");
            itemIndex++;
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalNumber)
    {
        _goals[goalNumber-1].RecordEvent();
        _score = 0;
        foreach(Goal goal in _goals)
        {
            
            _score += goal.GetTotalPoints();
        }
        
        if (_goals[goalNumber-1].IsComplete())
        {
            Console.WriteLine($"Goal '{_goals[goalNumber-1].GetShortName()}' is now complete!");
        }
    } 

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {       
            foreach (Goal goal in _goals)
            {    
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
                  
        }
    }

    public void LoadGoals(string fileName)
    {
        _goals.Clear(); 
                using (StreamReader reader = new StreamReader(fileName))
                {
                    try
                    {    
                        string line; // reading the file
                        while ((line = reader.ReadLine()) != null)
                        {
                            //int totalItems = _goals.Count +1;
                            string[] parts = line.Split("$");
                            //string type = parts[0];
                            if(parts.Length == 0) continue;
                            
                            if (parts[0] == "Simple Goal")
                            {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int totalPoints = int.Parse(parts[4]);

                            SimpleGoal goal = new SimpleGoal(name,description,points);
                            goal.SetTotalPoints(totalPoints);
                            _goals.Add(goal);
                            }

                            else if (parts[0] == "Eternal Goal")
                            {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int totalPoints = int.Parse(parts[4]);
                            EternalGoal goal = new EternalGoal(name,description,points); 
                            goal.SetTotalPoints(totalPoints); 
                            _goals.Add(goal);
                            }
                            else if (parts[0] == "Checklist Goal")
                            {
                                //int totalItems = _goals.Count +1;
                                string name = parts[1];
                                string description = parts[2];
                                int points = int.Parse(parts[3]);
                                int amountCompleted = int.Parse(parts[4]);
                                int target = int.Parse(parts[5]);
                                int bonus = int.Parse(parts[6]);
                                int totalPoints = int.Parse(parts[7]);

                                CheckListGoal goal = new CheckListGoal(name,description,points,target,bonus);
                                goal.SetTotalPoints(totalPoints);
                                goal.SetAmountCompleted(amountCompleted);
                                _goals.Add(goal);
                            }
                        }            
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error Loading Goals: {ex.Message}");
                    }
               }
    }

    public void Loading()
    {
       int timeDuration = 3 * 1000;
        int interval = 300; 
        int dotCount = 3; 

        Console.Write("Loading"); 

        DateTime endTime = DateTime.Now.AddMilliseconds(timeDuration);
        while (DateTime.Now < endTime)
        {
            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
                Thread.Sleep(interval);
            }
            
            Console.Write("\b\b\b   \b\b\b"); // Remove dots
            Thread.Sleep(interval);
        }

        Console.WriteLine(" Done!"); // Show completion message
    
    }
}