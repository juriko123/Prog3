using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    /// <summary>
    /// Razred registracija
    /// </summary>
    public class Registracija
    {
        private string obmocje;
        private string alfanumericni_del;
        private static string[] tabela_obmocij =  { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };

        //lastnosti
        public string Obmocje
        {
            get { return obmocje; }
            set
            {
                if (value.Length != 2)
                    throw new Exception("Za območja morata biti obvezno 2 znaka.");
                obmocje = value.ToUpper();
            }
        }

        public string Alfanumericni_del
        {
            get { return alfanumericni_del; }
            set
            {
                if (value.Length != 5)
                    throw new Exception("Pri alfanumericnem delu, mora biti natančno 5 znakov.");
                alfanumericni_del = value.ToUpper();
            }
        }

        public string[] Tabela_obmocij
        {
            get { return tabela_obmocij; }

        }

        //konstruktor
        public Registracija(string obmocje, string alfanumericni_del)
        {
            this.Obmocje = obmocje;
            this.Alfanumericni_del = alfanumericni_del;
        }

        public static void Izpisi_tabela_obmocij()
        {
            Console.WriteLine(string.Join(", ", tabela_obmocij));
        }


        public override string ToString()
        {
            return $"{Obmocje} {Alfanumericni_del}".ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Registracija avto = new Registracija("LJ", "NK123");
            avto.Obmocje = "GO";

            Random rand = new Random();
            string[] obmocja = { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
            List<Registracija> registracije = new List<Registracija>();

            Console.WriteLine("Tabela 100-ih registrskih stevilk: ");
            Console.WriteLine("[" + string.Join(", ", Ustvari(obmocja, registracije)) + "]");
            Console.WriteLine("==================================");
            Console.WriteLine($"Izpisi vse registrske številke iz podanega območja: {avto.Obmocje}");
            Izpisi_registrske_iz_obmocja(registracije, avto.Obmocje);
            Console.WriteLine("==================================");
            Console.WriteLine("Slovar, kjer je key regija in value je stevilo ponovitev:");
            Dictionary<string, int> slovar = new Dictionary<string, int>();

            foreach (Registracija el in registracije)
            {
                string[] tab = el.ToString().Split(' ');
                if (slovar.ContainsKey(tab[0]))
                    slovar[tab[0]] += 1;
                else
                    slovar[tab[0]] = 1;
            }

            foreach (var par in slovar)
            {
                Console.WriteLine($"Obmocje: {par.Key}, St. ponovitev: {par.Value}");
            }
            Console.WriteLine("==================================");
            List<Registracija> nova_tab = Izloceni(slovar, registracije);
            Console.WriteLine("Nova tabela brez Najpogostejsih oz najredkejsih je enaka: ");
            Console.WriteLine($"[{string.Join(", ", nova_tab)}]");

        }
        /// <summary>
        /// ustvari tabelo z 100 nakljucnimi registrskimi stevilkami
        /// </summary>
        /// <param name="obmocja">Iz katerih obmocij izbiramo</param>
        /// <param name="registracije">Kam shranjujemo</param>
        /// <returns>Vrne tabelo nizov z 100nakljucnimi registrskimi stevilkami oz. objekti</returns>
        public static List<Registracija> Ustvari(string[] obmocja, List<Registracija> registracije)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                string obmocje = obmocja[rand.Next(obmocja.Length)];
                string stevilka = GenerirajStevilko();
                registracije.Add(new Registracija(obmocje, stevilka));
            }

            return registracije;
        }

        /// <summary>
        /// Generira nakljucni drugi del registrske stevilke
        /// </summary>
        /// <param name="rand"></param>
        /// <returns>vrne nakljucni del registrske stevilke</returns>
        public static string GenerirajStevilko()
        {
            Random rand = new Random();
            string af_del = "";
            string crke_stevilke = "abcdefghijklmnoprstuvz1234567890";
            for (int i = 0; i < 5; i++)
            {
                af_del += crke_stevilke[rand.Next(crke_stevilke.Length)];
            }
            return af_del.ToUpper();
        }
        /// <summary>
        /// izpise registrske stevilke iz danega obmocja
        /// </summary>
        /// <param name="registracije">tavela registrskih stevilk</param>
        /// <param name="obmocje">katero obmocje damo</param>
        public static void Izpisi_registrske_iz_obmocja(List<Registracija> registracije,string obmocje)
        {
            foreach (Registracija el in registracije)
            {
                string[] tab = el.ToString().Split(' ');
                if (obmocje.ToUpper() == tab[0])
                {
                    Console.WriteLine(el);
                }
            }
        }
        /// <summary>
        /// iz tabele registrskih stevilk odstrani najpogostejse in najredkejse r stevilke
        /// </summary>
        /// <param name="slovar"></param>
        /// <param name="registracije"></param>
        /// <returns>tabelo brez najpogostejsih oz. najredkejsih r stevilk</returns>
        public static List<Registracija> Izloceni(Dictionary<string, int> slovar, List<Registracija> registracije)
        {
            List<Registracija> nova_tab = new List<Registracija>();
            int najvec = slovar.Values.Max();
            int najmanj = slovar.Values.Min();

            foreach (Registracija el in registracije)
            {
                string[] tab = el.ToString().Split(' ');
                if (najvec != slovar[tab[0]])
                    nova_tab.Add(el);
            }

            return nova_tab;
        }
    }
}
