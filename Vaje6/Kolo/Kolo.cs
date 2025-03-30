using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Kolo
{
    class Program
    {
        public class Kolo
        {
            private int prestava;
            private string barva;
            private string tip;
            private int leto_izdelave;
            private int ljudi_n;

            public int Prestava
            {
                get { return prestava; }
                set
                {
                    if (value < 1 || value > 6)
                        throw new Exception("Kolo ima samo 6 prestav");
                    prestava = value;
                }
            }
            public string Barva
            {
                get { return barva; }
                set { barva = value;}
                
            }
            public string Tip
            {
                get { return tip; }
                set { tip = value; }
            }
            public int Leto_izdelave
            {
                get { return leto_izdelave; }
                set
                {
                    if (value < 2000 || value > 2025)
                        throw new Exception("Ni mogoče");
                    leto_izdelave = value;
                }
            }
            public int Ljudi_n
            {
                get { return ljudi_n; }
                set
                {
                    if (value < 0 || value > 4)
                        throw new Exception("Kolo lahko vozi le od 1-4 ljudje");
                    ljudi_n = value;
                }
            }
            public Kolo()
            {
                this.Prestava = 6;
                this.Barva = "Modre";
                this.Tip = "Športne";
                this.Leto_izdelave = 2011;
                this.Ljudi_n = 2;

            }

            public Kolo(int prestava, string barva)
            {
                this.Prestava = prestava;
                this.Barva = barva;
                this.Tip = "Cestno";
                this.Leto_izdelave = DateTime.Now.Year;
                this.Ljudi_n = 2;
            }
               

            public Kolo(int prestava, string barva, string tip, int leto_izdelave, int ljudi_n)
            {
                this.Prestava = prestava;
                this.Barva = barva;
                this.Tip = tip;
                this.Leto_izdelave = leto_izdelave;
                this.Ljudi_n = ljudi_n;
            }

            public void Na_datoteko(string ime_datoteke)
            {
                using (StreamWriter pisi = File.AppendText(ime_datoteke))
                {
                    pisi.WriteLine($"{this.Prestava},{this.Barva},{this.Tip},{this.Leto_izdelave},{this.Ljudi_n}");
                }
            }

            public static Kolo Opis(string opis_kolesa)
            {
                string[] podatki = opis_kolesa.Split(',');
                if (podatki.Length != 5)
                    throw new Exception("Podatkov je prevec ali premalo");

                return new Kolo(int.Parse(podatki[0]), podatki[1], podatki[2], int.Parse(podatki[3]), int.Parse(podatki[4]));
            }

            public override string ToString()
            {
                return $"{this.Prestava},{this.Barva},{this.Tip},{this.Leto_izdelave},{this.Ljudi_n}".ToString();
            }
        }

        public static List<Kolo> Preberi(string ime_datoteke)
        {

            List<Kolo> tabela = new List<Kolo>();
            using (StreamReader beri = File.OpenText(ime_datoteke))
            {
                string vrstica = "";
                while ((vrstica = beri.ReadLine()) != null)
                {
                    string[] podatki = vrstica.Split(',');
                    tabela.Add
                        (
                          new Kolo(int.Parse(podatki[0]), podatki[1], podatki[2], int.Parse(podatki[3]), int.Parse(podatki[4]))
                        );
                }
                return tabela;
            }
        }

        public static int St_razlicnih_koles()
        {
            // hiter nacin
            /*int stevec = Preberi("Kolo.txt").Select(k => k.Barva).Distinct().Count();*/


            // z uporabo slovarja, damo barve v slovar in na koncu prestejemo dolzino slovarja
            Dictionary<string, int> hashmap = new Dictionary<string, int>();

            foreach (var element in Preberi("Kolo.txt"))
            {
                if (hashmap.ContainsKey(element.Barva))
                    hashmap[element.Barva] += 1;

                else
                    hashmap[element.Barva] = 1;
            }


            return hashmap.Count();
        }


        static void Main(string[] args)
        {
            //ustvarimo 3 objekte kolesa, vsakic drugi konstruktor
            Kolo ena = new Kolo();
            Kolo dva = new Kolo(3, "Zelena");
            Kolo tri = new Kolo(6, "Rdeča", "Gorsko", 2025, 3);
            Kolo stiri = new Kolo(6, "Rumena", "Gorsko", 2022, 3);
            Kolo pet = new Kolo(5, "Rumena", "Športno", 2012, 2);

            // vse tri objekte izpisemo na datoteko
            /*ena.Na_datoteko("Kolo.txt");
            dva.Na_datoteko("Kolo.txt");
            tri.Na_datoteko("Kolo.txt");
            stiri.Na_datoteko("Kolo.txt");
            pet.Na_datoteko("Kolo.txt");*/

            // uporabi metodo iz razreda Kolo, s pomocjo katere prebere prvo vrstico iz datoteke
            string preberi_z_datoteke = File.ReadLines("Kolo.txt").First();
            Kolo prebrano = Kolo.Opis(preberi_z_datoteke);
            Console.WriteLine(prebrano.ToString());

            //tabela 100koles.
            /*Random rand = new Random();
            List<Kolo> tabela_koles = new List<Kolo>();
            string[] barve = { "Modra", "Rdeča", "Zelena", "Črna", "Rjava" };
            string[] tipi = { "Gorsko", "Cestno", "Treking" };
            for (int i = 0; i < 100; i++)
            {
                //prestava, barva, tip, leto izdaje, ljudi_n
                Kolo novo_kolo = new Kolo
                (
                    rand.Next(1,3),
                    barve[rand.Next(barve.Length - 1)],
                    tipi[rand.Next(tipi.Length - 1)],
                    rand.Next(2000, 2025),
                    rand.Next(1, 4)
                );
                tabela_koles.Add(novo_kolo);
            }
            Console.WriteLine(string.Join(": ",tabela_koles));*/

            // tabela objektov iz datoteke
            List<Kolo> tab = Preberi("Kolo.txt");
            Console.WriteLine(string.Join(", ",tab));

            //izpis koliko različnih koles je v tabeli koles.
            Console.WriteLine(St_razlicnih_koles());

        }
    }
}
