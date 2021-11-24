using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can compare two or four numbers and find the bigger");
            Console.WriteLine();
            Console.WriteLine("Please choose: ");
            Console.WriteLine("\tCompare two numbers type 'Compare 2'\n\tCompare four numbers type 'Compare 4'");

            var userIn = Console.ReadLine();

            while (userIn.ToLower() != "compare 2" && (userIn.ToLower() != "compare 4"))
            {
                Console.WriteLine("This option doesn't exist. Please type an existing one.");
                userIn = Console.ReadLine();
            }

            if (userIn.ToLower() == "compare 2")
            {
                Console.Write("Please type the first number: ");
                double num;
                var a = Console.ReadLine();
                bool isNumber = double.TryParse(a, out num);

                while (!isNumber)
                {
                    Console.Write("This is not a number. Please type a number: ");
                    a = Console.ReadLine();
                    isNumber = double.TryParse(a, out num);
                }

                Console.Write("Please type the second number: ");
                var b = Console.ReadLine();
                bool isNumberB = double.TryParse(b, out num);

                while (!isNumberB)
                {
                    Console.Write("This is not a number. Please type a number: ");
                    b = Console.ReadLine();
                    isNumberB = double.TryParse(b, out num);
                }

                if (isNumber && isNumberB)
                {
                    double aNum = Convert.ToDouble(a);
                    double bNum = Convert.ToDouble(b);

                    double largerNumber = CompareTwoNumbers(aNum, bNum);
                    Console.WriteLine($"{largerNumber}");
                    Console.ReadKey();
                }
            }

            else if (userIn.ToLower() == "compare 4")
            {
                Console.Write("Please type the first number: ");
                double num;
                var a = Console.ReadLine();
                bool isNumber = double.TryParse(a, out num);

                while (!isNumber)
                {
                    Console.Write("This is not a number. Please type a number: ");
                    a = Console.ReadLine();
                    isNumber = double.TryParse(a, out num);
                }

                Console.Write("Please type the second number: ");
                var b = Console.ReadLine();
                bool isNumberB = double.TryParse(b, out num);

                while (!isNumberB)
                {
                    Console.Write("This is not a number. Please type a number: ");
                    b = Console.ReadLine();
                    isNumberB = double.TryParse(b, out num);
                }

                Console.Write("Please type the third number: ");
                var c = Console.ReadLine();
                bool isNumberC = double.TryParse(c, out num);

                while (!isNumberC)
                {
                    Console.Write("This is not a number. Please type a number: ");
                    c = Console.ReadLine();
                    isNumberC = double.TryParse(c, out num);
                }

                Console.Write("Please type the fourth number: ");
                var d = Console.ReadLine();
                bool isNumberD = double.TryParse(d, out num);

                while (!isNumberD)
                {
                    Console.Write("This is not a number. Please type a number: ");
                    d = Console.ReadLine();
                    isNumberD = double.TryParse(d, out num);
                }

                if (isNumber && isNumberB && isNumberC && isNumberD)
                {
                    double aNum = Convert.ToDouble(a);
                    double bNum = Convert.ToDouble(b);
                    double cNum = Convert.ToDouble(c);
                    double dNum = Convert.ToDouble(d);

                    double largerNumberOfFirstTwo = CompareTwoNumbers(aNum, bNum);
                    double largerNumberOfSecondTwo = CompareTwoNumbers(cNum, dNum);

                    double largerNumber = CompareTwoNumbers(largerNumberOfFirstTwo, largerNumberOfSecondTwo);

                    Console.WriteLine($"{largerNumber}");
                    Console.ReadKey();
                }
            }
        }

        private static double CompareTwoNumbers(double aNum, double bNum)
        {
            double result;

            if (aNum > bNum)
            {
                result = aNum;
            }

            else
            {
                result = bNum;
            }


            return result;

        }
    }
}
