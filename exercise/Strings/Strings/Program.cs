using System;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Choose a word and this program will tell you if it's included in our sentence. What is your word?");
            string word = Console.ReadLine();
            word = word.ToLower();
            int inSentence = firstSentence.ToLower().IndexOf(word);
            bool found = false;
            if (inSentence == -1)
            {
                Console.WriteLine(found + ", " + "your word was not in our sentence.");
            }
            else
            {
                Console.WriteLine(!found + ", " + "your word was in our sentence.");
                Console.WriteLine("It's at index: " + inSentence + ", it's length is: " + word.Length + ".");
                string removedWord = firstSentence.Remove(inSentence, word.Length);
                Console.WriteLine("Here is the sentence without your word: " + removedWord);
            }
        }
    }
}
