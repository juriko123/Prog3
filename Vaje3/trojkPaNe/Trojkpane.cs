using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace trojkPaNe
{
    class Trojkpane
    {
        /// <summary>
        /// Metoda gre skozi vsako število v tabeli in mu odreze stevko 3
        /// </summary>
        /// <param name="t">Referenca do vhodne tabele stevil</param>
        static void Krajsaj(ref int[] t)
        {
            List<int> novaTabela = new List<int>();
            foreach (int i in t)
            {
                string zapis = i.ToString();
                string zamenji = zapis.Replace("3", "");
                if (zamenji.Length > 0)
                    novaTabela.Add(int.Parse(zamenji));
            }
            t = novaTabela.ToArray();



        }
        /// <summary>
        /// Ustvarimo tabelo števil, nato pa pokličemo metodo Krajsaj
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] tabela = {13, 23, 333, 112, 3 };
            Krajsaj(ref tabela);
            Console.WriteLine(string.Join(",", tabela));
            
        }
    }
}
