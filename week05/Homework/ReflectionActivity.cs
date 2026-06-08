using System;

public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { }

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Think of a time when you did something really difficult...");
    }
}
