using System;
namespace Metoder_Test_C_A
{
    class program
    {
        static void Main(string[] args)
        {
            Meny();
           string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    CelsiusTillfahrenheit();
                    break;
                case "2":
                    FahrenheitTillCelcius();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("oacepterat svar");
                    break;

            }
            
        }
        static void Meny()
        {
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine(" ");
            Console.WriteLine("1. Omvandla från Celcius till Fahrenheit");
            Console.WriteLine("2. Omvandla från Fahrenheit till Celcius");
            Console.WriteLine("3. Avssluta programet");
            Console.WriteLine(" ");
        }
        static void CelsiusTillfahrenheit()
        {
            Console.WriteLine("Hur står mängd celcius vill du omandla?");
            Console.WriteLine(" ");
            string b = Console.ReadLine();
            double c =double.Parse(b);
            double d = (c * 1.8) + 32;
            Console.WriteLine(" ");
            Console.WriteLine(c + " grader celcius är samma som " + d + " grader fahrenheit");
        }
        static void FahrenheitTillCelcius()
        {
            Console.WriteLine("Hur står mängd fahrenheit vill du omandla?");
            Console.WriteLine(" ");
            string b = Console.ReadLine();
            double c = double.Parse(b);
            double d = (c -32) /1.8;
            Console.WriteLine(" ");
            Console.WriteLine(c + " grader fahrenheit är samma som " + d + " grader Celcius");
        }

    }
}

