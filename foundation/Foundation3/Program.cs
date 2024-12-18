using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("04 Nov 2022", 45, 20);
        Swimming swimming = new Swimming("05 Nov 2022", 25, 20);

        // Storing in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterating through the list and printing summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
