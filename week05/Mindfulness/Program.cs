using System;

// ==================================================================================
// CREATIVITY AND EXCEEDING REQUIREMENTS SHOWCASE:
// 1. Session Activity Tracker Log: Keeps an active log counter of how many times 
//    each specific mindfulness activity was successfully completed during the session.
// 2. Wrap-up Summary: When exiting (Option 4), the program outputs a meaningful 
//    breakdown of the user's total mindfulness engagement for that session.
// ==================================================================================

class Program
{
    static void Main(string[] args)
    {
        // Session log variables to track activity counts
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    reflectionCount++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;

                case "4":
                    keepRunning = false;
                    Console.Clear();
                    Console.WriteLine("Thank you for prioritizing your mindfulness today!");
                    Console.WriteLine("\n--- Your Session Summary ---");
                    Console.WriteLine($"Breathing Sessions Completed: {breathingCount}");
                    Console.WriteLine($"Reflection Sessions Completed: {reflectionCount}");
                    Console.WriteLine($"Listing Sessions Completed:    {listingCount}");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("\nGoodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please select an option from 1 to 4.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
