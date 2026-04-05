public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points, bool isComplete = false)
        : base(name, desc, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
        => _isComplete ? "[X] " + GetName() : "[ ] " + GetName();

    public override string GetSaveString()
        => $"Simple|{GetName()}|{GetPoints()}|{_isComplete}";
}