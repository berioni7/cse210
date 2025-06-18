public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points,
                         int targetCount, int bonusPoints, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent() => _timesCompleted++;
    public override bool IsComplete() => _timesCompleted >= _targetCount;
    public override string GetStatus() => IsComplete() ? "[X]" : $"[{_timesCompleted}/{_targetCount}]";
    public override string Serialize() =>
        $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_timesCompleted}";

    public int TimesCompleted => _timesCompleted;
    public int TargetCount => _targetCount;
    public int BonusPoints => _bonusPoints;
}
