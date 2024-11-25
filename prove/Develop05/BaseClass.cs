public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public void Start()
    {
        Console.WriteLine($"Starting {Name}: {Description}");
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowAnimation();
    }

    public void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {Name} for {Duration} seconds.");
        ShowAnimation();
    }

    public abstract void PerformActivity();

    private void ShowAnimation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
