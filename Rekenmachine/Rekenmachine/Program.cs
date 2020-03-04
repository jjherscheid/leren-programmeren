using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is een rekenmachine");

            Console.WriteLine("Wat is het eerste getal?");
            var eersteGetal = Console.ReadLine();

            Console.WriteLine("Wil je optellen of aftrekken (+ of -)");
            var plusOfMin = Console.ReadLine();

            Console.WriteLine("Wat is het tweede getal?");
            var tweedeGetal = Console.ReadLine();

            var uitkomst = Bereken(Convert.ToInt32(eersteGetal), Convert.ToInt32(tweedeGetal), plusOfMin);
            
            Console.WriteLine($"De som: {eersteGetal}{plusOfMin}{tweedeGetal}={uitkomst}");
        }

        static int Bereken(int getal1, int getal2, string plusOfMin)
        {
            if (plusOfMin == "+")
            {
                return getal1 + getal2;
            }

            if (plusOfMin == "-")
            {
                return getal1 - getal2;
            }

            return 0;
        }
    }
}
