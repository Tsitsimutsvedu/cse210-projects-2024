public class ChecklistGoal : Goal
    {
        public int TargetCount { get; set; }
        public int CurrentCount { get; set; }
        public int BonusPoints { get; set; }

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
        {
            TargetCount = targetCount;
            CurrentCount = 0;
            BonusPoints = bonusPoints;
        }

        public override int RecordEvent()
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                return Points + BonusPoints;
            }
            return Points;
        }

        public override bool IsCompleted()
        {
            return CurrentCount >= TargetCount;
        }
    }
