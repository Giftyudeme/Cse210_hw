using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a single list containing different activity types
            List<Activity> activities = new List<Activity>();

            // Add activities to the list
            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
            activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 6.0));
            activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));

            // Iterate and display summaries using polymorphism
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
