using System;

namespace ConverterFuelConsumption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts fuel consumtion\nin Liters per 100 Killometres to Miles per Gallon and vice versa");
            Console.WriteLine("Please choose: ");
            Console.WriteLine("\tConverting from Litres per 100 Killometres to Miles per Gallon\n\ttype 'EU to USA'\n\tConverting from Miles per Gallon to Liters per 100 Killometres\n\ttype 'USA to EU'");

            var userIn = Console.ReadLine();

            while (userIn.ToLower() != "eu to usa" && (userIn.ToLower() != "usa to eu"))
            {
                Console.WriteLine("This option doesn't exist. Please write an excisting one.");
                userIn = Console.ReadLine();
            }

            if (userIn.ToLower() == "eu to usa")
            {
                EUToUSA();
            }

            else
            {
                USAToEU();
            }
        }

        private static void EUToUSA()
        {
            Console.Write("Please type vlue in Liters per 100 Killometres\n(If your number is a decimal please separate it with a comma ',': ");
            double num;
            var valueInEU = Console.ReadLine();
            bool isNumber = double.TryParse(valueInEU, out num);

            while (!isNumber)
            {
                Console.WriteLine("This is not a number. Please type a number in Liters per 100 Killometres:");
                valueInEU = Console.ReadLine();
                isNumber = double.TryParse(valueInEU, out num);
            }

            if (isNumber)
            {
                double valueInEUNum = Convert.ToDouble(valueInEU);
                double result = (100 / valueInEUNum) / 1.609 * 3.78;
                double resultRounded = Math.Round(result, 2);

                Console.WriteLine($"The fuel consumption\nin {valueInEU} Liters per 100 Killometres is {resultRounded} Miles per Gallon");
            }

            Console.ReadKey();
        }

        private static void USAToEU()
        {
            Console.Write("Please type vlue in Miles per Gallon\n(If your number is a decimal please separate it with a comma ',': ");
            double num;
            var valueInUSA = Console.ReadLine();
            bool isNumber = double.TryParse(valueInUSA, out num);

            while (!isNumber)
            {
                Console.WriteLine("This is not a number. Please type a number in Miles per Gallon:");
                valueInUSA = Console.ReadLine();
                isNumber = double.TryParse(valueInUSA, out num);
            }

            if (isNumber)
            {
                double valueInUSANum = Convert.ToDouble(valueInUSA);
                double result = (1 / valueInUSANum) * 3.78 / 1.609 * 100;
                double resultRounded = Math.Round(result, 2);

                Console.WriteLine($"The fuel consumption\nin {valueInUSA} Miles per Gallon is {resultRounded} Liters per 100 Killometres");
            }

            Console.ReadKey();
        }
    }
}
