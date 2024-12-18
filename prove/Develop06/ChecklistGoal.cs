class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string description, int points, int targetCount, int bonusPoints) : base(description, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        currentCount++;
    }

    public override bool IsComplete()
    {
        return currentCount >= targetCount;
    }

    public override string GetProgress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }

    public int GetBonusPoints()
    {
        return IsComplete() ? bonusPoints : 0;
    }
}

