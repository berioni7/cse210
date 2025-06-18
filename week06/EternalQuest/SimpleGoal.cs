public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent() => _isComplete = true;
    public override bool IsComplete() => _isComplete;
    public override string GetStatus() => IsComplete() ? "[X]" : "[ ]";
    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}
