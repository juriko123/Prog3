using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsote
{
    class Program
    {
        static int[] vk(int[] seznam, int k)
        // za dani seznam in naravno število k izračunaj seznam vsot vseh strnjenih podseznamov dolžine k
        {
            if (k > seznam.Length || k < 0)
                return Array.Empty<int>();
            int dolzinaSeznama = seznam.Length;
            int[] rezultat = new int[dolzinaSeznama - k + 1]; //dolzina koncne tabele bo tolikokrat kot lahko izracunamo vsoto
            int vrednost = 0;

            for (int i = 0; i < k; i++)
            {
                vrednost += seznam[i];
            }
            rezultat[0] = vrednost;

            for (int i = k; i < dolzinaSeznama; i++)
            {
                vrednost = vrednost - seznam[i - k] + seznam[i];
                rezultat[i - k + 1] = vrednost;
            }

            return rezultat;
        }
        static void Main(string[] args)
        {
            Random rand= new Random();

            Console.Write("Vnesi k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Vnesi velikost seznama: ");
            int velikostSeznama = int.Parse(Console.ReadLine());

            int[] seznam = new int[velikostSeznama];
            for (int i = 0; i < velikostSeznama; i++)
            {
                seznam[i] = rand.Next(10);
            }
            Console.WriteLine("Naš seznam je: [" + String.Join(",", seznam) + "]");
            int[] odgovor = vk(seznam, k);
            Console.WriteLine("Vsote so: " + String.Join(",", odgovor));
            
        }
    }
}
