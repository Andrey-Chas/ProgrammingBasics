using System;

namespace Greeting
{
    class Homework1
    {
        static void Main(string[] args)
        {
            Greeting();
        }
        private static void Greeting()
        {
            try
            {
                Console.Write("Please type a number between 1 and 7: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Please type time between 0 and 23: ");
                int time = int.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Monday today. Weekend is coming in 5 days");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Monday today. Weekend is coming in 5 days");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Monday today. Weekend is coming in 5 days");
                        }
                        break;

                    case 2:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Tuesday today. Weekend is coming in 4 days");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Tuesday today. Weekend is coming in 4 days");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Tuesday today. Weekend is coming in 4 days");
                        }
                        break;

                    case 3:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Wednesday today. Weekend is coming in 3 days");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Wednesday today. Weekend is coming in 3 days");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Wednesday today. Weekend is coming in 3 days");
                        }
                        break;

                    case 4:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Thursday today. Weekend is coming in 2 days");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Thursday today. Weekend is coming in 2 days");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Thursday today. Weekend is coming in 2 days");
                        }
                        break;

                    case 5:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Friday today. Weekend is coming in 1 days");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Friday today. Weekend is coming in 1 days");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Friday today. Weekend is coming in 1 days");
                        }
                        break;

                    case 6:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Saturday today. Weekend is here!");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Saturday today. Weekend is here!");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Saturday today. Weekend is here!");
                        }
                        break;

                    case 7:
                        if (time >= 6 && time < 12)
                        {
                            Console.WriteLine("Good morning, it is a lovely Sunday today. Weekend is here!");
                        }
                        else if (time >= 12 && time < 18)
                        {
                            Console.WriteLine("Good day, it is a lovely Sunday today. Weekend is here!");
                        }
                        else if (time >= 18 || time >= 0)
                        {
                            Console.WriteLine("Good evening, it is a lovely Sunday today. Weekend is here!");
                        }
                        break;

                    default:
                        Console.WriteLine("This day doesn't exist");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
