using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity>activityList = new List<Activity>();
        activityList.Add(new Cycling("01/02/2025", 20, 1.450));
        activityList.Add(new Running("10/02/2025", 20, 1.450));
        activityList.Add(new Swimming("19/02/2025", 20, 50));
        foreach(Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}