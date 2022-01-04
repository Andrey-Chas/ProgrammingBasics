using System;
using System.Collections.Generic;

namespace WordSentenceToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program capitalizes a word or a sentence");
            Console.WriteLine("Please choose: ");
            Console.WriteLine("\tFor capitalizing a word type 'word'\n\tFor capitalizing a sentence type 'sentence'");

            string userIn = Console.ReadLine();
            while (userIn.ToLower() != "word" && (userIn.ToLower() != "sentence"))
            {
                Console.WriteLine("This option doesn't exist. Please type an existing one.");
                userIn = Console.ReadLine();
            }

            if (userIn.ToLower() == "word")
            {
                Console.Write("Please type a word: ");
                userIn = Console.ReadLine();
                string word = WordToUpper(userIn);

                Console.WriteLine($"{word}");
                Console.ReadKey();
            }

            if (userIn.ToLower() == "sentence")
            {
                Console.Write("Please type a sentence: ");
                userIn = Console.ReadLine();
                string sentence = SentenceToUpper(userIn);
                string sentenceThroughWord = SentenceThroughWord(userIn);

                Console.WriteLine($"{sentence} through the own function");
                Console.WriteLine($"{sentenceThroughWord} through the word function");
                Console.ReadKey();
            }
        }

        static public string WordToUpper(string word)
        {
            List<string> wordList = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                wordList.Add(word);
            }
            string wordToUpper = word.ToUpper();
            return wordToUpper;
        }

        static public string SentenceToUpper(string sentence)
        {
            string sentenceToUpper = sentence.ToUpper();
            return sentenceToUpper;
        }

        static public string SentenceThroughWord(string sentence)
        {
            string throughWordToUpper = WordToUpper(sentence);
            return throughWordToUpper;
        }
    }
}
