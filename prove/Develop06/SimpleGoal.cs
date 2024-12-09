public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override int RecordEvent()
        {
            return Points;
        }

        public override bool IsCompleted()
        {
            return true;
        }
    }
