public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points,
        int target, int bonus, int count = 0)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        if (_count >= _target) return 0;

        _count++;
        if (_count == _target)
            return GetPoints() + _bonus;

        return GetPoints();
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetStatus()
        => $"[{(_count >= _target ? "X" : " ")}] {GetName()} ({_count}/{_target})";

    public override string GetSaveString()
        => $"Checklist|{GetName()}|{GetPoints()}|{_target}|{_bonus}|{_count}";
}