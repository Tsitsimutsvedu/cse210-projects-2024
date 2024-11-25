public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void PerformActivity()
    {
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
