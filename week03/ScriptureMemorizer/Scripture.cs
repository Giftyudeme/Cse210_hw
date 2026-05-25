using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        // 1. Private member variables (Encapsulation)
        private Reference _reference;
        private List<Word> _words;

        // 2. Constructor
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Break the sentence into an array of individual string words
            string[] splitWords = text.Split(' ');
            
            // Loop through each string, create a Word object, and add it to our list
            foreach (string wordText in splitWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        // 3. Methods
        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            
            // STRETCH CHALLENGE: Filter to find only words that are NOT already hidden
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            // Prevent an error if there are fewer visible words left than the requested number to hide
            int itemsToHide = Math.Min(numberToHide, visibleWords.Count);

            for (int i = 0; i < itemsToHide; i++)
            {
                // Select a random index from our list of visible words
                int index = random.Next(visibleWords.Count);
                
                // Call the Hide() method on that specific Word object
                visibleWords[index].Hide();
                
                // Remove it from our temporary tracking list so it cannot be selected twice in the same turn
                visibleWords.RemoveAt(index);
            }
        }

        public string GetDisplayText()
        {
            // Join all the words (or their underscores) back together into a clean sentence
            string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
            
            // Combine the formatted reference and the text string
            return $"{_reference.GetDisplayText()} - {scriptureText}";
        }

        public bool IsCompletelyHidden()
        {
            // Returns true only if every single word object in our list returns true for IsHidden()
            return _words.All(w => w.IsHidden());
        }
    }
}
