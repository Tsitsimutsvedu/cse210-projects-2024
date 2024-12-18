class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string description, int points) : base(description, points)
    {
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetProgress()
    {
        return isComplete ? "[X]" : "[ ]";
    }
}

