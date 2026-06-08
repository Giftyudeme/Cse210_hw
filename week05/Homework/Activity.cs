using System;

public abstract class Activity
{
    // Private variables (Encapsulation)
    private string _name;
    private string _description;
    private int _duration;

    // Constructor to set up the activity
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // This is the "brain" method that will run the steps in order
    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        // (We will add the spinner animation here later!)
        
        // This calls the specific activity code
        ExecuteActivity();

        Console.WriteLine("\nWell done!!");
    }

    // Child classes MUST fill this out with their own unique logic
    protected abstract void ExecuteActivity();

    // Helper to let child classes know how much time they have
    protected int GetDuration()
    {
        return _duration;
    }
}
