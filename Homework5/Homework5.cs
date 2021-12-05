using System;

namespace Homework5
{
    class Homework5
    {
        static void Main(string[] args)
        {
            //SpaceMeOut();
            //Number();
            RemoveDups();
        }

        private static void SpaceMeOut()
        {
            // 1. Input

            Console.Write("Please type a word: ");
            string word = Console.ReadLine();

            // 2. Adding spaces and output
            foreach (char letter in word)
            {
                Console.Write($"{letter} ");
            }
        }

        private static void Number()
        {

            // 1. Define varibles
            string[] array = { "(", "", "", "", ")", " ", "", "", "", "-", "", "", "", "" };

            // 2. Input data
            Console.Write("Please type your phone number (10 numbers): ");
            string number = Console.ReadLine();

            array[1] = Convert.ToString(number[0]);
            array[2] = Convert.ToString(number[1]);
            array[3] = Convert.ToString(number[2]);
            array[6] = Convert.ToString(number[3]);
            array[7] = Convert.ToString(number[4]);
            array[8] = Convert.ToString(number[5]);
            array[10] = Convert.ToString(number[6]);
            array[11] = Convert.ToString(number[7]);
            array[12] = Convert.ToString(number[8]);
            array[13] = Convert.ToString(number[9]);

            // 3. Output data
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        private static void RemoveDups()
        {
            string[] array = { "array", "hello", "hi", "hello" };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int compare = i + 1; compare < array.Length; compare++)
                {
                    if (array[i] == array[compare])
                    {
                        array[compare] = " ";
                        for (int i1 = 0; i1 < array.Length; i1++)
                        {
                            Console.Write($"{array[i1]} ");
                        }
                    }
                }
            }
        }
    }
}
