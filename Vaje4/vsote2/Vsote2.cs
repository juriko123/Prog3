using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsote2
{
    class Program
    {
        /// <summary>
        /// metoda sesteje vsa števila v tabeli
        /// </summary>
        /// <param name="tabela"> tabela int števil</param>
        /// <returns>vrne vosto vseh števil</returns>
        static int Sestej(int[] tabela)
        {
            int vsota = tabela[0];
            for (int i = 1; i < tabela.Length; i++)
            {
                vsota += tabela[i];
            }
            return vsota;
        }
        
        /// <summary>
        /// metoda zlepi vse nize skupaj
        /// </summary>
        /// <param name="tabela">tabela nizov</param>
        /// <returns> vrne skupek vseh nizov</returns>
        static string Sestej(string[] tabela)
        {
            string niz = tabela[0];
            for (int i = 1; i < tabela.Length; i++)
            {
                niz += tabela[i];
            }
            return niz;
        }
        static void Main(string[] args)
        {
            int[] tabela = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Sestej(tabela));

            string[] tabela1 = { "Dober", " ", "dan", " ", "Jurij" };
            Console.WriteLine(Sestej(tabela1));
        }
    }
}
