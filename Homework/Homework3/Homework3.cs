using System;

namespace Homework3
{
    class Homework3
    {
        static void Main(string[] args)
        {
            Romb();
        }

        private static void Romb()
        {
            int n = 5;

            for (int row = 1; row <= n; row++)
            {
                for (int space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }

                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{column}");
                }

                for (int column1 = row - 1; column1 > 0; column1--)
                {
                    Console.Write($"{column1}");
                }

                Console.WriteLine();
            }

            n = 10;

            for (int row1 = 6; row1 <= n; row1++)
            {
                for (int space = 6; space <= row1; space++)
                {
                    Console.Write(" ");
                }

                for (int column = 1; column <= n - row1; column++)
                {
                    Console.Write($"{column}");
                }

                for (int column1 = 9 - row1; column1 > 0; column1--)
                {
                    Console.Write($"{column1}");
                }

                Console.WriteLine();
            }
        }
    }
}
