using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpisTabele
{
    class Izzzpisitabele
    {
        /// <summary>
        /// metoda izpise tabelo po vrsticah, ne glede na kateri tip tabele je 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"> tabela iz vhodnih podatkov</param>
        /// <param name="n"> kje se vrstica lomi</param>
        /// <param name="locilo"> locilo med elementi</param>
        static void Izpisi<T>(T[] tabela, int n, string locilo)
        {
            for (int i=0; i<tabela.Length;i++)
            {
                if (i  == (tabela.Length - 1))
                {
                    Console.WriteLine(tabela[i]);
                    break;
                }
                if ((i+1) % n != 0)
                    Console.Write(tabela[i] + locilo);
                else
                {
                    Console.WriteLine(tabela[i]);
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] tabela = new int[] { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            Izpisi(tabela, 5 , " : ");

            char[] besede = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Izpisi(besede, 3, " | ");

            bool[] logicne = { true, false, true, true, false };
            Izpisi(logicne, 2, " & ");
        }
    }
}
