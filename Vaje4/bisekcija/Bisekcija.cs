using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bisekcija
{
    class Bisekcija
    {
        /// <summary>
        /// metoda s pomočjo bisekcije poišče če je v tabeli iskana vrednost
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela">tabela</param>
        /// <param name="vrednost">isakana vrednost</param>
        /// <returns>vrne true če vrednost je v tabeli, če je ni vrne false</returns>
        static bool BBisekcija<T>(T[] tabela, T vrednost) where T: IComparable<T>
        {
            int levo = 0;
            int desno = tabela.Length - 1;
            while (levo <= desno)
            {
                int sredina = (levo + desno) / 2;
                int primerjava = tabela[sredina].CompareTo(vrednost);

                if (primerjava == 0)
                    return true;
                else if (primerjava < 0)
                {
                    levo = sredina + 1;
                }
                else 
                {
                    desno = sredina - 1;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] tabela = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(BBisekcija(tabela, 2));

            char[] besede = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Console.WriteLine(BBisekcija(besede, 'f'));


        }
    }
}
