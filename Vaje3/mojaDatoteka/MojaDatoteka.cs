using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mojaDatoteka
{
    class MojaDatoteka
    {
        /// <summary>
        /// Ustvari novo datoteko pod nekim imenon(ce ta ne ze obstaja), vanjo izpise to je moja datoteka in različna imena,
        /// izpise prebrano
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Vnesi ime datoteke: ");
            string ime_datoteke = Console.ReadLine() + ".txt";

            if (!File.Exists(ime_datoteke))
                using (StreamWriter pisanje = File.CreateText(ime_datoteke))
                {
                    pisanje.WriteLine("Moja datoteka");
                }

            using (StreamReader branje = File.OpenText(ime_datoteke))
            {
                string vrstica = branje.ReadLine();
                Console.WriteLine(vrstica);
            }

            using (StreamWriter dodajanje = File.AppendText(ime_datoteke))
            {
                Console.Write("Vnesi ime: ");
                string ime = Console.ReadLine();
                dodajanje.WriteLine(ime);
            }


            using (StreamReader dodatno_branje = File.OpenText(ime_datoteke))
            {
                int i = 0;
                string vrstica = dodatno_branje.ReadLine();
                while (vrstica != null)
                {
                    Console.WriteLine(++i + ": " + vrstica);
                    vrstica = dodatno_branje.ReadLine();
                }
            }






            
        }
    }
}
