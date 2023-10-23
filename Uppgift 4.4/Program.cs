using System;
using System.Diagnostics;

namespace Uppgift4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";

            while (val != "3")
            {
                Console.WriteLine("Välj ett av följande alternativ, skriv siffran:");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1": 
                        Console.WriteLine("Du valde alternativ 1, skriv in ditt första tal: ");
                        double tal1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in ditt andra tal: ");
                        double tal2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(tal1 + " subtraherat med " + tal2 + " blir " + (tal1 - tal2));
                        break;

                    case "2":
                        Console.WriteLine("Du valde alternativ 2, skriv in ditt första tal: ");
                        double tal3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in ditt andra tal: ");
                        double tal4 = double.Parse(Console.ReadLine());
                        Console.WriteLine(tal3 + " subtraherat med " + tal4 + " blir " + (tal3 / tal4));
                        break;

                    case "3":
                        Console.WriteLine("Du valde alternativ 3, programmet avslutas");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt alternativ, försök igen: ");
                        break;
                }
            }
        }
    }
}