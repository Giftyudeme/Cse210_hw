public class EternalGoal : Goal
{
    public override bool IsComplete() => false; // Never complete

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points; // Always returns points every time it's recorded
    }

    public override string GetDetailsString()
    {
        return $"[ ] {ShortName} ({Description}) — Eternal Quest";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{ShortName},{Description},{Points}";
    }
}
