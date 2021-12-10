using System;

namespace ArrayCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates minimum, maximum, sum and avarage\nof the numbers in an array");
            int[] numbers = { 28, 58, 2, 32, 34, 7, 128, 79, 53, 9, 8, 700, 23, 420, 85, 5 };

            // Converting to string in order to display initial array

            string numbersText = string.Join(",", numbers);

            Console.WriteLine($"Here are numbers: {numbersText}");

            int minInArray = MinInArray(numbers);
            int maxInArray = MaxInArray(numbers);
            int sumInArray = SumInArray(numbers);
            double averageInArray = Math.Round(AverageInArray(numbers), 2);
            Console.WriteLine($"Minimum number in the array is: {minInArray}");
            Console.WriteLine($"Maximum number in the array is: {maxInArray}");
            Console.WriteLine($"Sum of the numbers in the array is: {sumInArray}");
            Console.WriteLine($"Average of the numbers in the array is: {averageInArray}");

            Console.ReadKey();

        }
        static public int MinInArray(int[] array)
        {
            Array.Sort(array);
            int minNum = array[0];

            return minNum;
        }

        static public int MaxInArray(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            int maxNum = array[0];

            return maxNum;
        }

        static public int SumInArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            return sum;
        }

        static public double AverageInArray(int[] array)
        {
            double average = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            average = sum / array.Length;

            return average;
        }
    }
}
