
namespace EternalQuest

    public abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; protected set; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public abstract int RecordEvent();

        public abstract bool IsCompleted();
    }

