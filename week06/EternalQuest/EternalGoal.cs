public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent()
    {
        return GetPoints(); // always gives points
    }

    public override bool IsComplete() => false;

    public override string GetStatus()
        => "[∞] " + GetName();

    public override string GetSaveString()
        => $"Eternal|{GetName()}|{GetPoints()}";
}