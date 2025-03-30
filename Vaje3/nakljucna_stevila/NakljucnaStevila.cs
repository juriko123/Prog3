using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakljucna_stevila
{
    class NakljucnaStevila
    {
        static Random rand = new Random();
        /// <summary>
        /// Metoda generira naključna števila in jih vstavi v tabelo, dolzine d
        /// </summary>
        /// <param name="m"> Do katerega števila naj bodo naključne stevke </param>
        /// <param name="d"> pove velikost tabele </param>
        /// <returns> Vrne tabelo naključnih števil </returns>
        static int[] NakjlucnaStevila(int m, int d)
        {
            //metoda generira nakljucna stevila in jih da v tabelo
            int[] tabelaNakljucnih = new int[d];
            for (int i = 0; i < d; i++)
            {
                tabelaNakljucnih[i] = rand.Next(1, m + 1);
            }

            return tabelaNakljucnih;
        }
        /// <summary>
        /// Metoda iz tabele ustvari niz
        /// </summary>
        /// <param name="stevila">tabela števil</param>
        /// <param name="locilo">locilo med števili</param>
        /// <returns>Vrne niz ki ima za ločila "locilo"</returns>
        static string TabelaKotNiz(int[] stevila, char locilo)
        {
            // iz tabele celih stevil vrne niz z uporabnikovim locilom
            string niz = string.Join(locilo.ToString(), stevila);
            return niz;
        }
        /// <summary>
        /// Iz niza ustavrimo tabelo, kjer je umes stevil v nizu presledek
        /// </summary>
        /// <param name="s"> Niz iz vhodnih podatkov</param>
        /// <returns>Vrne tabelo števil</returns>
        static int[] NizKotTabela(string s)
        {
            // iz niza naredi tabelo 
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s = s.Replace(" ","");
                }
            }

            int[] tabela = new int[s.Length];

            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = Convert.ToInt32(s[i]);
            }

            return tabela;
            

        }
        /// <summary>
        /// Za nakljucnastevila, tabelo kot niz in niz kot tabelo prebere podatke in izpiše njihove metode
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //za nakljucna
            Console.Write("Koliko naj bo dolzina tabele?: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Do katerega stevila naj bodo nakljucni elementi?: ");
            int m = int.Parse(Console.ReadLine());

            int[] nakljucna = NakjlucnaStevila(m, d);
            Console.WriteLine(string.Join(", ", nakljucna));

            //za tabela kot niz
            int[] stevila = new int[] { 1, 2, 3, 4, 5, 6, 7, 89 };
            Console.Write("Kaksno locilo zeliš med elementi? ");
            char locilo = char.Parse(Console.ReadLine());
            string stevila_v_nizu = TabelaKotNiz(stevila, locilo);
            Console.WriteLine(stevila_v_nizu);

            //za iz niza v tabelo
            string s = "1 2 3 4";
            Console.WriteLine(NizKotTabela(s));
        }
    }
}
