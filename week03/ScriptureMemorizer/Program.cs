using System;
using System.Collections.Generic;
using System.IO;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * EXCEEDING THE REQUIREMENTS / CREATIVITY REPORT:
             * 1. STRETCH CHALLENGE: Words are filtered in Scripture.cs so hidden words aren't chosen twice.
             * 2. FILE LOADING: Scripture data is dynamically loaded from an external "scriptures.txt" file.
             * 3. INFINITE PLAY: The game resets and loads a fresh scripture when the user presses Enter at the end.
             */

            string filePath = "scriptures.txt";
            List<string> rawLines = new List<string>();

            // 1. Read the raw text lines from the file once at the start
            if (File.Exists(filePath))
            {
                rawLines.AddRange(File.ReadAllLines(filePath));
            }

            // Fallback line if file is missing or empty
            if (rawLines.Count == 0)
            {
                rawLines.Add("Proverbs|3|5|6|Trust in the Lord with all thine heart and lean not unto thine own understanding.");
            }

            Random rand = new Random();
            bool keepPlaying = true;

            // Outer loop for switching to a brand new scripture
            while (keepPlaying)
            {
                // 2. Pick a random raw line from our list
                string randomLine = rawLines[rand.Next(rawLines.Count)];
                
                // 3. Parse that line into a brand-new, clean Scripture object
                string[] parts = randomLine.Split('|');
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = (endVerse == 0) 
                    ? new Reference(book, chapter, startVerse) 
                    : new Reference(book, chapter, startVerse, endVerse);

                Scripture selectedScripture = new Scripture(reference, text);

                // Inner game loop for memorizing the current scripture
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(selectedScripture.GetDisplayText());
                    Console.WriteLine();

                    // If completely hidden, prompt to continue or quit
                    if (selectedScripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("Excellent! You have memorized this scripture.");
                        Console.WriteLine("\nPress Enter to try a new random verse, or type 'quit' to exit completely:");
                        string response = Console.ReadLine();
                        
                        if (response.Trim().ToLower() == "quit")
                        {
                            keepPlaying = false;
                        }
                        break; // Breaks out of the inner loop to fetch a new scripture line
                    }

                    Console.WriteLine("Press Enter to hide words, or type 'quit' to exit:");
                    string input = Console.ReadLine();

                    if (input.Trim().ToLower() == "quit")
                    {
                        keepPlaying = false;
                        break; // Breaks out of inner loop
                    }

                    selectedScripture.HideRandomWords(3);
                }
            }
            
            Console.Clear();
            Console.WriteLine("Goodbye! Good luck with your memorization!");
        }
    }
}
