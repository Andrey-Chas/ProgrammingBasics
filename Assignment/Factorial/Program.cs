using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates factorial");
            Console.Write("Please type a whole non-negative number: ");
            int num;
            var x = Console.ReadLine();
            bool isNumber = int.TryParse(x, out num);

            while (!isNumber || Convert.ToInt32(x) < 0)
            {
                Console.Write("This is not a number or it is a decimal number or is a negative number.\nPlease type a whole non-negative number: ");
                x = Console.ReadLine();
                isNumber = int.TryParse(x, out num);
            }

            if (isNumber)
            {
                int xInt = Convert.ToInt32(x);
                Factorial(xInt);
                int factorialOfANum = Factorial(xInt);

                Console.WriteLine($"The factorial of {xInt} is: {factorialOfANum}");
                Console.ReadKey();
            }
        }

        private static int Factorial(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
