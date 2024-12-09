using System;

public class Program
{
    static void Main(string[] args)
   
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Goal> goals = new List<Goal>
            {
                new SimpleGoal("Run a marathon", 1000),
                new EternalGoal("Read scriptures", 100),
                new ChecklistGoal("Attend temple", 50, 10, 500)
            };

            foreach (var goal in goals)
            {
                Console.WriteLine($"{goal.Name} - Points: {goal.RecordEvent()}, Completed: {goal.IsCompleted()}");
            }
        }
    }
}
