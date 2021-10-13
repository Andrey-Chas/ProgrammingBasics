using System;

namespace ConverterTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fahrenheit = (Celsius * 1.8) + 32
            //Celsius = Fahrenheit - 32/1.8

            Console.WriteLine("This program converts Celsius degrees to Fahrenheit degrees and vice versa.\nAlso, this program can compare the temperature between\nCelsius degrees and Fahrenheit degrees.");
            Console.WriteLine();
            Console.WriteLine("Please choose: ");
            Console.WriteLine("\tConverting from Celsius to Fahrenheit type 'C to F'\n\tConverting from Fahrenheit to Celsius type 'F to C'\n\tComparing between temperatures type 'compare'");
            
            var userIn = Console.ReadLine();
            double num;
            
            while (userIn.ToLower() != "c to f" && (userIn.ToLower() != "f to c") && (userIn.ToLower() != "compare"))
            {
                Console.WriteLine("This option does't exit. Please write an excisting one.");
                userIn = Console.ReadLine();
            }


            if (userIn.ToLower() == "c to f")
            {
                Console.WriteLine("Please write temperature in Celsius\n(If your number is a decimal please separate it with a comma ','): ");
                var temInC = Console.ReadLine();
                bool isNumber = double.TryParse(temInC, out num);
                while (!isNumber)
                {
                    Console.WriteLine("This is not a number. Please type a number in Celsius:");
                    temInC = Console.ReadLine();
                    isNumber = double.TryParse(temInC, out num);
                }

                if (isNumber)
                {
                    var result = (Convert.ToDouble(temInC) * 1.8) + 32;
                    var resultRounded = Math.Round(result, 2);
                    Console.WriteLine($"{result} Fahrenheit degrees");
                }
            }

            else if (userIn.ToLower() == "f to c")
            {
                Console.WriteLine("Please write temperature in Fahrenheit\n(If your number is a decimal please separate it with a comma ','): ");
                var temInF = Console.ReadLine();
                bool isNumber = double.TryParse(temInF, out num);
                while (!isNumber)
                {
                    Console.WriteLine("This is not a number. Please type a number in Fahrenheit:");
                    temInF = Console.ReadLine();
                    isNumber = double.TryParse(temInF, out num);
                }

                if (isNumber)
                {
                    var result = (Convert.ToDouble(temInF) - 32)/1.8;
                    var resultRounded = Math.Round(result, 2);
                    Console.WriteLine($"{resultRounded} Celsius degrees");
                }
            }

            else if (userIn.ToLower() == "compare")
            {
                Console.WriteLine("Please write temperature in Celsius\n(If your number is a decimal please separate it with a comma ','): ");
                var temInC = Console.ReadLine();
                bool isNumberC = double.TryParse(temInC, out num);
                while (!isNumberC)
                {
                    Console.WriteLine("This is not a number. Please type a number in Celsius:");
                    temInC = Console.ReadLine();
                    isNumberC = double.TryParse(temInC, out num);
                }

                Console.WriteLine("Please write temperature in Fahrenheit\n(If your number is a decimal please separate it with a comma ','): ");
                var temInF = Console.ReadLine();
                bool isNumber = double.TryParse(temInF, out num);
                while (!isNumber)
                {
                    Console.WriteLine("This is not a number. Please type a number in Fahrenheit:");
                    temInF = Console.ReadLine();
                    isNumber = double.TryParse(temInF, out num);
                }

                if (isNumber && isNumberC)
                {
                    float temInCNum = (float)Convert.ToDouble(temInC);
                    float temInFNum = (float)Convert.ToDouble(temInF);

                    double resultInF = (Convert.ToDouble(temInC) * 1.8) + 32;
                    double resultInC = (Convert.ToDouble(temInF) - 32) / 1.8;

                    double temInCNumRounded = Math.Round(temInCNum, 2);
                    double temInFNumRounded = Math.Round(temInFNum, 2);

                    double resultInFRounded = Math.Round(resultInF, 2);
                    double resultInCRounded = Math.Round(resultInC, 2);

                    if (temInCNum > resultInC)
                    {
                        var differenceInC = temInCNumRounded - resultInCRounded;
                        var differenceInF = temInFNumRounded - resultInFRounded;

                        var differenceInCRounded = Math.Round(differenceInC, 2);
                        var differenceInFRounded = Math.Round(differenceInF, 2);

                        Console.WriteLine($"Requested to compare:\n\t{temInCNumRounded} Celsius degrees - {resultInFRounded} Fahrenheit degrees\n\t{temInFNumRounded} Fahrenheit degrees - {resultInCRounded} Celsius degrees");
                        Console.WriteLine();
                        Console.WriteLine($"The temperature in {temInCNumRounded} Celsius degrees is greater\nthan the temperature in {resultInCRounded} Celsius degrees on {differenceInCRounded} Celsius degrees");
                        Console.WriteLine();
                        Console.WriteLine($"The temperature in {temInFNumRounded} Fahrenheit degrees is less\nthan the temperature in {resultInFRounded} Fahrenheit degrees on {differenceInFRounded} Fahrenheit degrees");
                    }

                    else if (temInCNum < resultInC)
                    {
                        var differenceInC = temInCNumRounded - resultInCRounded;
                        var differenceInF = temInFNumRounded - resultInFRounded;

                        var differenceInCRounded = Math.Round(differenceInC, 2);
                        var differenceInFRounded = Math.Round(differenceInF, 2);

                        Console.WriteLine($"Requested to compare:\n\t{temInCNumRounded} Celsius degrees - {resultInFRounded} Fahrenheit degrees\n\t{temInFNumRounded} Fahrenheit degrees - {resultInCRounded} Celsius degrees");
                        Console.WriteLine();
                        Console.WriteLine($"The temperature in {temInCNumRounded} Celsius degrees is less\nthan the temperature in {resultInCRounded} Celsius degrees on {differenceInCRounded} Celsius degrees");
                        Console.WriteLine();
                        Console.WriteLine($"The temperature in {temInFNumRounded} Fahrenheit degrees is greater\nthan the temperature in {resultInFRounded} Fahrenheit degrees on {differenceInFRounded} Fahrenheit degrees");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
