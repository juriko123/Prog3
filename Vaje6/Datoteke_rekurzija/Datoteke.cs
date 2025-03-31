using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datoteke_rekurzija
{
    class Program
    {
        /// <summary>
        /// Rekurzivno preišče vse imenike in poišče tiste, ki vsebujejo iskano datoteko.
        /// </summary>
        /// <param name="trenutniImenik">Trenutni imenik, ki ga pregledujemo.</param>
        /// <param name="datoteka">Ime iskane datoteke.</param>
        /// <param name="iskano">Seznam imenikov, ki vsebujejo iskano datoteko.</param>
        static void NajdiImeniki(string trenutniImenik, string datoteka, List<string> iskano)
        {
            if (Directory.Exists(trenutniImenik)) // Preverimo, ali imenik obstaja
            {
                if (File.Exists(Path.Combine(trenutniImenik, datoteka))) // Preverimo, ali datoteka obstaja
                {
                    iskano.Add(trenutniImenik);
                }

                foreach (string podimenik in Directory.GetDirectories(trenutniImenik)) // Rekurzivno obiščemo podimenike
                {
                    NajdiImeniki(podimenik, datoteka, iskano);
                }
            }
        }

            static void Main(string[] args)
        {
            string zacetni_imenik = @"C:\Users\Jurij\Desktop\c#\Prog3\Vaje6\";
            string iskana_dat = "App.config";

            List<string> imeniki = new List<string>();

            NajdiImeniki(zacetni_imenik, iskana_dat, imeniki);

            Console.WriteLine("Imeniki, ki vsebujejo dano datoteko: ");
            foreach (string imenik in imeniki)
            {
                Console.WriteLine(imenik);
            }
        }
    }
}
