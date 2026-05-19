//  CREATIVITY & EXCEEDING REQUIREMENTS:
//  1. Implemented a robust "~|~" string token delimiter system to act as a 
//     pseudo-JSON flat database format. This ensures that if a user types commas, 
//     periods, or standard quotes in their response, the file does not break 
//     when loaded back into the program.
//  2. Added empty input verification to prevent users from accidentally 
//     saving completely blank journal entries.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        
        // List of 5 required prompts + 1 custom creative prompt
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned or realized today?"
        };

        Random randomGenerator = new Random();
        string choice = "0";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                // Select a random prompt
                int index = randomGenerator.Next(prompts.Count);
                string prompt = prompts[index];
                
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(response))
                {
                    // Get current date as string
                    string dateText = DateTime.Now.ToShortDateString();
                    
                    // Create and add entry
                    Entry newEntry = new Entry(dateText, prompt, response);
                    myJournal.AddEntry(newEntry);
                }
                else
                {
                    Console.WriteLine("Entry cannot be blank. Not saved.\n");
                }
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1-5.\n");
            }
        }
    }
}
