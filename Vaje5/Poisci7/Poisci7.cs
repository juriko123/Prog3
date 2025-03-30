using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisci7
{
    class Program
    {
        /// <summary>
        /// metoda, poišče števila, ki so deljiva z 7, in ce so jih izbrise iz tabele
        /// </summary>
        /// <param name="tabela">tabela vhodnih podatkov</param>
        /// <returns> vrne katera stevila so deljiva, in vsa ostala števila, ter novo tabelo</returns>
        /// <exception cref="Exception"></exception>
        public static int[] Poisci_sedem(ref int[] tabela)
        {
            if (tabela == null || tabela.Length == 0)
            {
                throw new Exception("Tabela ne sme biti prazna");
            }

            List<int> nova_tabela = new List<int>();

            int[] resitev = new int[2];
            int deljiva = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] % 7 == 0)
                    deljiva++;
                else
                    nova_tabela.Add(tabela[i]);
            }

            tabela = nova_tabela.ToArray(); 

            resitev[0] = deljiva;
            resitev[1] = tabela.Length - deljiva;
            return resitev;
        }
        static void Main(string[] args)
        {
            int[] tabela = { 23, 7, 15, 49, 17 };
            Console.WriteLine($"Število deljivih števil z 7 je: {Poisci_sedem(ref tabela)[0]}, vseh ostalih števil je: {Poisci_sedem(ref tabela)[1]}");
            Console.WriteLine("Nova tabela izgleda tako: " + "[" + string.Join(", ", tabela) + "]");
        }
    }
}
