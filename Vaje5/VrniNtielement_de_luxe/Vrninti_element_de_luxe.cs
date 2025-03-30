using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrniNtielement_de_luxe
{

    class Program
    {
        /// <summary>
        /// Vrne n-ti element iz konca če je mozno
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"> tabela</param>
        /// <param name="n"> kateri indeks izpisemo, ce lahko</param>
        /// <returns> vrne nti element </returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static T VrniNtiElement<T>(T[] tabela, int n)
        {
            if (tabela == null || tabela.Length == 0)
            {
                throw new ArgumentException("Tabela ne sme biti prazna.");
            }

            int dolzina = tabela.Length; 

            if (n == 0 || Math.Abs(n) > dolzina)
            {
                throw new IndexOutOfRangeException("Napačen indeks.");
            }

            int indeks;
            if (n > 0)
            {
                indeks = n - 1;
            }
            else
            {
                indeks = dolzina + n; 
            }

            return tabela[indeks];
        }

        static void Main()
        {
            string[] blebetanje = { "bla", "blo", "bli" };
            int[] tja = { 10, 20, 30 };

            Console.WriteLine(VrniNtiElement(blebetanje, 2)); 
            Console.WriteLine(VrniNtiElement(blebetanje, -3)); 

            // Naslednje vrstice sprožijo izjeme, zato so zakomentirane:
            Console.WriteLine(VrniNtiElement(blebetanje, 1));
            // Console.WriteLine(VrniNtiElement(tja, 0)); 
            // Console.WriteLine(VrniNtiElement(tja, 4));

            Console.WriteLine(VrniNtiElement(tja, 1)); // 10
        }
    }
}
