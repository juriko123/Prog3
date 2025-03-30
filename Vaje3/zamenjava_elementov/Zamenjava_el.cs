using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamenjava_elementov
{
    class Zamenjava_el
    {
        /// <summary>
        /// Ustvari kopijo podane tabele t
        /// </summary>
        /// <param name="t"> Referenca na tabelo iz vhodnih podatkov </param>
        /// <returns>vrne kopijo tabele t</returns>
        static int[] Kopija(int[] t)
        {
            //ustvarimo novo tabelo, v katero bomo shranili iste elemente kot v tabeli a.
            // tako ustvarimo kopijo tabele

            int[] novaTabela = new int[t.Length];
            for (int i = 0; i < novaTabela.Length; i++)
            {
                novaTabela[i] = t[i];
            }

            return novaTabela;  
        }

        /// <summary>
        /// Izpiše elemente tabele na konzolo
        /// </summary>
        /// <param name="ime"> Ime tabele, ki bo prikazano pred elementi</param>
        /// <param name="t"> Tabela, katere elemente zelimo prepisati</param>
        static void Izpisi(string ime, int[] t)
        {
            Console.WriteLine(string.Join(",", t));
        }
        /// <summary>
        /// Prikazuje zamenjavo elementov med dvema tabelama
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = Kopija(a);
            Console.WriteLine("Prej: "); Izpisi("a", a); Izpisi("b", b);
            a[1] = b[2];
            a[2] = b[1];
            Console.WriteLine("Potem: "); Izpisi("a", a); Izpisi("b", b);
            
            
        }
    }
}
