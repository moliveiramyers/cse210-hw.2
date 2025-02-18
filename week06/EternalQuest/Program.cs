// Exceeding requirements:
// Loading method to the GoalManager class that displays an animation when running some methods (lines 208)
// Try tool - Added in the Goal manager to handdle errors softly and continue with the program instead of crashing (lines 106 and 213)
// Display the current progress as soon as record an event for checklist goal, so it make easier (Checklist class lines 34) 



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager play1 = new GoalManager();
        play1.Start();
    }
}