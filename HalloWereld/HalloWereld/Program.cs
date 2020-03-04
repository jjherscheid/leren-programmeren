using System;
using System.Collections.Generic;

namespace HalloWereld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo wereld!");
            
            Console.WriteLine("Wie ben jij:");
            var naam = Console.ReadLine();
            Console.WriteLine($"Hallo {naam}");

            Console.WriteLine("Hoe oud ben je:");
            var leeftijd = Console.ReadLine();
            Console.WriteLine($"Je ben {leeftijd} jaar oud");

            Console.WriteLine("Waar woon je:");
            var plaats = Console.ReadLine();
            Console.WriteLine($"Je woont in {plaats}");
        }
    }
}
