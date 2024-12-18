abstract class Goal
{
    private string description;
    private int points;

    public Goal(string description, int points)
    {
        this.description = description;
        this.points = points;
    }

    public string Description
    {
        get { return description; }
    }

    public int Points
    {
        get { return points; }
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetProgress();
}
