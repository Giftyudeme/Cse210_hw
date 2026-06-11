using System;

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by listing them.")
    { }

    protected override void ExecuteActivity()
    {
        Console.WriteLine("List as many items as you can...");
    }
}
