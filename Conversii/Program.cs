using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversii
{
    internal class Program
    {
        private static long numarBaza10;

        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            string numarInput = Console.ReadLine();

            Console.Write("Introduceti baza initiala (b1): ");
            int b1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti baza de conversie (b2): ");
            int b2 = int.Parse(Console.ReadLine());

            try
            {
                // Conversie
                string rezultat = ConvertBase(numarInput, b1, b2);

                Console.WriteLine($"Rezultatul conversiei este: {rezultat}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}");
            }
        }

        static string ConvertBase(string numar, int b1, int b2)
        {
            if (b1 < 2 || b1 > 16 || b2 < 2 || b2 > 16)
            {
                throw new ArgumentException("Bazele trebuie sa fie intre 2 si 16.");
            }

            // Conversie
            int numarDecimal = Convert.ToInt32(numar, b1);

            // Conversie
            string rezultat = Convert.ToString(numarDecimal, b2);

            return rezultat;
        }
    }
}
