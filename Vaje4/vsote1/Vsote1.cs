using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsote1
{
    class Program
    {
        /// <summary>
        /// Metoda izračuna vsoto tabele na generičen način
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"> Tabela, elementov</param>
        /// <returns> Vrne (dynamic) vsoto </returns>
        static dynamic Sestej<T>(T[] tabela)
        {
            dynamic vsota = tabela[0];
            //moremo začeti od drugega elementa naprej, saj prvega ze imamo

            for (int i = 1; i < tabela.Length; i++)
            {
                vsota += (dynamic)tabela[i];
            }

            return vsota;
        }
        static void Main(string[] args)
        {
            int[] tabela = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Sestej(tabela));

            string[] tabela1 = new string[] { "Dober"," ", "dan", " " ,"Jurij"};
            Console.WriteLine(Sestej(tabela1));
        }
    }
}
