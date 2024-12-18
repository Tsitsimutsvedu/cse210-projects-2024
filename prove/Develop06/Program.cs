using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures daily", 100));
        goals.Add(new ChecklistGoal("Attend the temple 10 times", 50, 10, 500));

        
        goals[0].RecordEvent(); // Complete the marathon
        goals[1].RecordEvent(); // Read scriptures once
        for (int i = 0; i < 10; i++) // Complete checklist goal
        {
            goals[2].RecordEvent();
        }

        // Display goals and calculate score
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetProgress()} - {goal.Description}");
            totalScore += goal.Points;
            if (goal is ChecklistGoal checklistGoal)
            {
                totalScore += checklistGoal.GetBonusPoints();
            }
        }

        Console.WriteLine($"Total Score: {totalScore}");
    }
}
