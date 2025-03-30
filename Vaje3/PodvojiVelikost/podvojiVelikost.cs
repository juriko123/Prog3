using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodvojiVelikost
{
    class podvojiVelikost
    {
        /// <summary>
        /// Metoda podvoji velikost tabele stevil, tako da ustvari pomozno tabelo, ji nastavi velikost na x2 
        /// in ji prepiše elemente.
        /// Na koncu se referenciramo
        /// </summary>
        /// <param name="t">Referenca na vhodno tabelo števil</param>
        static void PodvojiVelikost(ref int[] t)
        {
            
            //metoda podvoji velikost tabele
            int[] pomoznaTab = new int[t.Length * 2];
            for (int i = 0; i < t.Length; i++)
            {
                pomoznaTab[i] = t[i];
            }

            t = pomoznaTab;
        }
        /// <summary>
        /// Sprejme neko tabelo, in izpise isto tabelo z 2x vecjo velikostjo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] tabela = new int[] { 1, 2, 3, 4 };
            PodvojiVelikost(ref tabela);
            Console.WriteLine(string.Join(", ", tabela));
        }
    }
}
