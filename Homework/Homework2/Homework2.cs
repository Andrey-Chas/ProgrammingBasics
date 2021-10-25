using System;

namespace Validation
{
    class Homework2
    {
        static void Main(string[] args)
        {
            Validation();

            Console.ReadKey();
        }

        private static void Validation()
        {
            Console.Write("Please type your first name (required, max length = 100): ");
            string firstName = Console.ReadLine();

            int num;
            bool firstNameIsNum = int.TryParse(firstName, out num);

            if (firstName.Length >= 100)
            {
                Console.WriteLine("The first name is too large");
                Exit();
            }

            else if (firstName == "")
            {
                Console.WriteLine("This field is required");
                Exit();
            }

            else if (firstNameIsNum)
            {
                Console.WriteLine("You typed a number");
                Exit();
            }

            else
            {
                Console.Write("Please type your last name (required, max length = 100): ");
                string lastName = Console.ReadLine();

                bool lastNameIsNum = int.TryParse(lastName, out num);

                if (lastName.Length >= 100)
                {
                    Console.WriteLine("The last name is too large");
                    Exit();
                }

                else if (lastName == "")
                {
                    Console.WriteLine("This field is required");
                    Exit();
                }

                else if (lastNameIsNum)
                {
                    Console.WriteLine("You typed a number");
                    Exit();
                }

                else
                {
                    try
                    {
                        Console.Write("Please type your date of birth\n(in the form of DD.MM.YYYY, max years = 100): ");
                        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                        string dateOfBirthYears = dateOfBirth.ToString("yyyy");
                        int dateOfBirthYearsConverted = Convert.ToInt32(dateOfBirthYears);

                        DateTime years = DateTime.Now;

                        var differenceInYears = years.AddYears(-dateOfBirthYearsConverted);

                        if (differenceInYears.Year >= 100)
                        {
                            Console.WriteLine("Years exceed the limit");
                            Exit();
                        }

                        else
                        {
                            Console.WriteLine("Please type your student number\nin the form YYYYFFSSNNNN(length = 12): ");
                            string studentNumber = Console.ReadLine();

                            if (studentNumber.Length == 12)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Your information:\n\tFirts name: {firstName}\n\tLast name: {lastName}\n\tDate of birth: {dateOfBirth:dd.MM.yyyy}\n\tStudent number: {studentNumber}");
                            }

                            else
                            {
                                Console.WriteLine("Student number length must be 12 characters");
                                Exit();
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Date of birth was typed in the wrong form");
                        Exit();
                    }
                }
            }
        }

        private static void Exit()
        {
            try
            {
                string a = "a";
                int num = int.Parse(a);
            }
            catch
            {
                Console.WriteLine("Please reload the program");
            }
        }
    }
}
