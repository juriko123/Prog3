using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax1
{
    class Program
    {
        /// <summary>
        /// metoda primerja med sabo elemente v tabeli
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"> tabela iz vhodnih podatkov</param>
        /// <returns> vrne 2 elementa; najvecjega in najmanjsega</returns>
        static T[] MinMax<T>(T[] tabela) where T : IComparable<T>
        {
            T najmanjsi = tabela[0];
            T najvecji = tabela[0];

            //koda ce zelimo vse v eni metodi.
            foreach (T element in tabela)
            {
                if (typeof(T) == typeof(string))
                {
                    int najkrajsi = ((string)(object)najmanjsi).Length; // T najprej v Object nato v string
                    int najdaljsi = ((string)(object)najvecji).Length;
                    int trenutna_dolzina_elementa = ((string)(object)element).Length;

                    if (trenutna_dolzina_elementa > najdaljsi)
                        najvecji = element;
                    if (trenutna_dolzina_elementa < najkrajsi)
                        najmanjsi = element;

                }
                else
                {
                    if (element.CompareTo(najvecji) > 0)
                        najvecji = element;
                    if (element.CompareTo(najmanjsi) < 0)
                        najmanjsi = element;
                }
            }

            T[] nova = { najvecji, najmanjsi };

            return nova;
        }
        /* S mopočjo dodatne metode, dosti lazje
        public static string[] MinMax(string[] tabela)
        { 
            string najkrajsi = tabela[0];
            string najdaljsi = tabela[0];

            foreach (string element in tabela)
            {
                if (element.Length < najkrajsi.Length)
                    najkrajsi = element;
                if (element.Length > najdaljsi.Length)
                    najdaljsi = element;
            }

            return new string[] { najkrajsi, najdaljsi };
        }
        */


        static void Main(string[] args)
        {
            int[] tabela = { 1, 23, 4, 54, 8, 49, 5, 19, 84, 987, 984, 894 };
            Console.WriteLine($"{MinMax(tabela)[0]}, {MinMax(tabela)[1]}");

            string[] tabela1 = { "miha", "tone", "tomaz", "jurij", "nejc", "anej"};
            Console.WriteLine($"{MinMax(tabela1)[0]}, {MinMax(tabela1)[1]}");
        }
    }
}
