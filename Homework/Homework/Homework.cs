using System;

namespace Homework
{
    class Homework
    {
        static void Main(string[] args)
        {
            //Printing Hello and the name on a separate line

            Console.WriteLine("Hello");
            Console.WriteLine("Andrey!");
            Console.WriteLine();

            //Sum of two numbers
            Console.WriteLine(5 + 127);
            Console.WriteLine();

            //Program that completes the following operations
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 35) % 7);
            Console.WriteLine(14 + (-4) * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine();

            //Program that multiply three numbers entered by the user
            try
            {
                Console.Write("Please enter the first number: ");
                int numA = int.Parse(Console.ReadLine());

                Console.Write("Please enter the second number: ");
                int numB = int.Parse(Console.ReadLine());

                Console.Write("Please enter the third number: ");
                int numC = int.Parse(Console.ReadLine());

                Console.WriteLine(numA * numB * numC);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            //Program that will print the multiplication table of a number
            try
            {
                Console.Write("Please type a number to print the multiplication table of this number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num} * 1 = {num * 1}");
                Console.WriteLine($"{num} * 2 = {num * 2}");
                Console.WriteLine($"{num} * 3 = {num * 3}");
                Console.WriteLine($"{num} * 4 = {num * 4}");
                Console.WriteLine($"{num} * 5 = {num * 5}");
                Console.WriteLine($"{num} * 6 = {num * 6}");
                Console.WriteLine($"{num} * 7 = {num * 7}");
                Console.WriteLine($"{num} * 8 = {num * 8}");
                Console.WriteLine($"{num} * 9 = {num * 9}");
                Console.WriteLine($"{num} * 10 = {num * 10}");
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            //Program that takes four numbers and output the avarage
            try
            {
                Console.Write("Please type the first number: ");
                int firstNum = int.Parse(Console.ReadLine());

                Console.Write("Please type the second number: ");
                int secondNum = int.Parse(Console.ReadLine());

                Console.Write("Please type the third number: ");
                int thirdNum = int.Parse(Console.ReadLine());

                Console.Write("Please type the fourth number: ");
                int fourthNum = int.Parse(Console.ReadLine());

                Console.WriteLine($"The avarage of these numbers is {(firstNum + secondNum + thirdNum + fourthNum) / 4}");
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            //Program that detrimnes if the number is within the range between 100 and 200
            try
            {
                Console.Write("Please type a number to find out if it is within the range between 100 and 200: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(100 < number && number < 200);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            //Program that prints the current day, month and year
            DateTime DMY = DateTime.Now;

            Console.WriteLine($"Current day, month and year: {DMY:dd-MM-yyyy}");
            Console.WriteLine();

            //Program that asks for the user age and displayes the year of birth
            try
            {
                Console.Write("Please type your age: ");
                int age = int.Parse(Console.ReadLine());

                DateTime years = DateTime.Now;
                Console.WriteLine($"You were born in {years.AddYears(-age):yyyy}");
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            //Program that takes three numbers and outputs them in the following format (number + number1).number2 and number.number1 + number1.number2
            try
            {
                Console.Write("Please type the first number: ");
                string x = (Console.ReadLine());

                Console.Write("Please type the second number: ");
                string y = (Console.ReadLine());

                Console.Write("Please type the third number: ");
                string z = (Console.ReadLine());

                double convertedX = double.Parse(x);
                double convertedY = double.Parse(y);
                double convertedZ = double.Parse(z);

                Console.WriteLine($"{convertedX + convertedY},{convertedZ}");
                string newNum = x + "," + y;
                string newNum1 = y + "," + z;

                double convertedNewNum = double.Parse(newNum);
                double convertedNewNum1 = double.Parse(newNum1);

                Console.WriteLine(convertedNewNum + convertedNewNum1);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadKey();
        }
    }
}
