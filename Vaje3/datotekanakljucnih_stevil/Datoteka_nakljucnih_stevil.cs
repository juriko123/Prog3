using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datotekanakljucnih_stevil
{
    class Datoteka_nakljucnih_stevil
    {
        /// <summary>
        /// Ustvari datoteko, v katero se izpišejo nakjlucna stevila
        /// </summary>
        /// <param name="ime"> Referenca na kako se bo datoteka imenovala</param>
        /// <param name="maxvrstic"> Referenca na koliko naj bo ma vrstic</param>
        /// <param name="maxstevil">Referenca na koliko naj bo najvec stevil </param>
        /// <param name="maxvrednost"> Referenca na koliko je lahko najvišja vrednost</param>
        static void Ustvari(string ime, int maxvrstic, int maxstevil, int maxvrednost)
        {
            // ustvari datoteko v nakeri je nakljucno stevilo vrstic, stevil 
            Random rand = new Random();
            if (!File.Exists(ime))
                using (StreamWriter dat = File.CreateText(ime))
                {
                }
            using (StreamWriter dodajanje = File.AppendText(ime)) // Vsakic ko pozenemo se bo na isto datoteko dodajale nove stvari
            {
                int vrstic = rand.Next(1, maxvrstic + 1);
                for (int i = 0; i < vrstic; i++)
                {
                    int stevil = rand.Next(1, maxstevil + 1);
                    for (int j = 0; j < stevil; j++)
                    {
                        dodajanje.Write(rand.Next(0, maxvrednost) + (j < stevil - 1 ? " " : ""));//enako kot pogojni stavek v pythong: " " if j<stevil-1 else ""
                    }
                    dodajanje.WriteLine();
                }
            }
        }
        /// <summary>
        /// Iz datoteke na konzolo izpiše vsebino datoteke, doloci tudi ce je poravnano ali ne
        /// </summary>
        /// <param name="ime"> Referenca na kako se datoteka imenuje</param>
        /// <param name="poravnaj">Ze doloceno v parametru</param>
        static void Izpis(string ime, int poravnaj = 1)
        {
            using (StreamReader beri = new StreamReader(ime))
            {
                string vrstica;
                while ((vrstica = beri.ReadLine()) != null)
                {
                    if (poravnaj > 0)
                    {
                        string[] stevila = vrstica.Split(' ');
                        foreach (string st in stevila)
                        {
                            Console.Write(st.PadLeft(poravnaj) + ";");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(vrstica);
                    }
                }
            }
        }
        /// <summary>
        /// Poklice zgoraj omenjene metode
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string ime_datoteke = "nakljucna.txt";
            Ustvari(ime_datoteke, 5, 10, 10);
            Izpis(ime_datoteke);   
        }
    }
}
