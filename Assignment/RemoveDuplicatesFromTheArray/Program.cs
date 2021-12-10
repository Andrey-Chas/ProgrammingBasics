using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program deletes duplictes from an array");
            string[] array = { "Hello", "Something", "Car", "Car", "Amazing", "Cat", "Dog", "Cat" };

            string arrayText = string.Join(",", array);
            Console.WriteLine($"Initial array: {arrayText}");
            string[] arrayWithoutDuplicates = RemoveDuplicates(array);
            Console.WriteLine($"Array without duplicates: {string.Join(",", arrayWithoutDuplicates)}");

            Console.ReadKey();
        }

        static public string[] RemoveDuplicates(string[] array)
        {
            List<string> arrayList = new List<string>(array);

            for (int i = 0; i < arrayList.Count; i++)
            {
                for (int j = i + 1; j < arrayList.Count; j++)
                {
                    if (arrayList[i] == arrayList[j])
                    {
                        arrayList.Remove(arrayList[j]);
                    }
                }
            }

            string[] convertToArray = arrayList.ToArray();

            return convertToArray;
        }
    }
}