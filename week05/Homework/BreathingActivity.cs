using System;

public class BreathingActivity : Activity
{
    // Call the parent constructor to set the name and description
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Breathe in...");
        // (We will add loops and timers here next!)
    }
}
