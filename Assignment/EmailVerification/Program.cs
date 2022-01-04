using System;
using System.ComponentModel.DataAnnotations;

namespace EmailVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks if email is valid");
            Console.Write("Please type an email: ");
            string email = Console.ReadLine();

            string isEmailValid = VerifyEmail(email);

            while (isEmailValid == "")
            {
                Console.Write("The email was not entered. Please type an email: ");
                email = Console.ReadLine();
                isEmailValid = VerifyEmail(email);

                while (isEmailValid == "Your email is not valid")
                {
                    Console.Write("The email is not valid. Please type a valid email: ");
                    email = Console.ReadLine();
                    isEmailValid = VerifyEmail(email);
                }
            }

            while (isEmailValid == "Your email is not valid")
            {
                Console.Write("The email is not valid. Please type a valid email: ");
                email = Console.ReadLine();
                isEmailValid = VerifyEmail(email);

                while (isEmailValid == "")
                {
                    Console.Write("The email was not entered. Please type an email: ");
                    email = Console.ReadLine();
                    isEmailValid = VerifyEmail(email);
                }
            }

            Console.WriteLine($"{isEmailValid}");
            Console.ReadKey();
        }

        static public string VerifyEmail(string email)
        {
            if (email == "")
            {
                string value = "";

                return value;
            }

            else if (new EmailAddressAttribute().IsValid(email))
            {
                string isValid = "Your email is valid";
                return isValid;
            }

            else
            {
                string isNotValid = "Your email is not valid";
                return isNotValid;
            }
        }
    }
}
