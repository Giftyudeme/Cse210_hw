public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override bool IsComplete() => false;

    public override int RecordEvent()
    {
        // Returns a negative value to deduct score
        return -Points; 
    }

    public override string GetDetailsString()
    {
        return $"[!] {ShortName} ({Description}) — Bad Habit (Deducts {Points} pts)";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{ShortName},{Description},{Points}";
    }
}
