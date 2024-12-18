 class EternalGoal : Goal
{
    public EternalGoal(string description, int points) : base(description, points)
    {
    }

    public override void RecordEvent()
    {
        // Always incomplete because it's eternal
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetProgress()
    {
        return "[∞]";
    }
}
