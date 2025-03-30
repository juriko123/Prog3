using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piton_na_obisku
{
    class Program
    {  
        static string prestej(string s, string t)
        //prešteje, kako pogosto se vsak znak iz niza t pojavi v nizu s, nato pa vrne vse znake iz t,
        //ki se pojavljajo največkrat v s. Znak, ki se pojavi največkrat, je vrnjen v obliki niza.
        {
            int[] c = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                int countCrke = s.Count(crka => crka == t[i]);
                c[i] = countCrke;
            }
            // ali int maxOdC = c.Max();
            int maxOdC = 0;
            for (int j=0; j < c.Length; j++)
            {
                if (c[j] > maxOdC)
                {
                    maxOdC = c[j];
                }
            }

            //tukaj bo problem ker nevemo koliko bo dolga tabela u....
            //char[] u = new char[t.Length];
            List<char> u = new List<char>();

            for (int z = 0; z < t.Length; z++)
            {
                if (c[z] == maxOdC)
                {
                    u.Add(t[z]);
                }
            }

            //return string.Concat(u);// izpise string
            string izpis = "";
            for (int i = 0; i < u.Count; i++)
            {
                izpis = izpis + u[i];
            }

            return izpis;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(prestej("neznani tekst", "taei"));
        }
    }
}
