using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hisne_stevilke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo številko: ");
            int zacetna = int.Parse(Console.ReadLine());

            Console.Write("Vnesi zadnjo številko: ");
            int koncna = int.Parse(Console.ReadLine());

            // slovar v c#
            Dictionary<char, int> stevilke = new Dictionary<char, int>();
            for (char c = '0'; c <= '9'; c++)
            {
                stevilke[c] = 0;
            }

            for (int i = zacetna; i <= koncna; i++)
            {
                foreach (char c in i.ToString())
                {
                    stevilke[c]++;
                }
            }

            Console.WriteLine("\nPotrebujemo naslednje števke:");
            foreach (var kljucvrednost in stevilke)
            {
                Console.WriteLine($"{kljucvrednost.Key}: {kljucvrednost.Value}x");
            }
        }   
    }
}
