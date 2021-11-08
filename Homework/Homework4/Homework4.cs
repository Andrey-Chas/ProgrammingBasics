using System;

namespace Homework4
{
    class Homework4
    {
        static void Main(string[] args)
        {
            Coding();
        }
        private static void Coding()
        {
            string[] array1 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " " };

            string[] array2 = { "d", "a", "z", "h", "f", "e", "c", "j", "m", "o", "l", "q", "s", "u", "v", "x", "g", "w", "y", "b", "r", "k", "p", "i", "t", "n", " " };

            Console.Write("Please type a text: ");
            string text = Console.ReadLine();

            foreach (char letter in text.ToLower())
            {
                for (int i = 0; i <= array1.Length; i++)
                {
                    if (Convert.ToString(letter) == array1[i])
                    {
                        Console.Write(array2[i]);
                        break;
                    }
                }
            }
        }
    }
}
