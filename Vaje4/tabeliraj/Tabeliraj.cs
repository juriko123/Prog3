using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lovljenjeNapak
{
    class Tabeliraj
    {
        /// <summary>
        /// Metoda preveri uporabnikov vnos števila, in glede nanj preveri ali je to stevilo vredu ali ne
        /// </summary>
        /// <returns>vrne uporabnikovo stevilo</returns>
        static int VnosStevila()
        {
            bool run = true;
            while (run)
            {
                try
                {
                    Console.Write("Vpiši poljubno pozitivno celo število: ");
                    int stevilo = int.Parse(Console.ReadLine());
                    if (stevilo <= 0)
                        Console.WriteLine("Število mora biti večje od 0");
                    else
                    {
                        return stevilo;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vnos mora biti celo število.");
                }
            }
            return 0;
        }
        /// <summary>
        /// meotda naredi nek izraz
        /// </summary>
        /// <param name="i">sprejme število število i, ki pride iz metode tabeliraj</param>
        /// <returns>vrne število, ki ga izraz izračuna</returns>
        static int F(int i)
        {
            return 100 / (i % 3);
        }
        /// <summary>
        /// metoda naredi tabelo velikosti število tipa int, za vsak index pregledamo zgornjo metodo F(i)
        /// če dobimo, da je imenovalec enak 0 vrnemo napako in nastavimo indeks na 0, drugače nastavimo indeks v tabeli 
        /// na izračunan izraz
        /// </summary>
        /// <param name="stevilo"> določi velikost tabele, uporanik ga določi</param>
        static void Tabeliraj1(int stevilo)
        {
            int[] tabela = new int[stevilo];
            for (int i = 0; i < tabela.Length; i++)
            {
                try
                {
                    tabela[i] = F(i);
                }
                catch (DivideByZeroException)
                {
                    tabela[i] = 0;
                }
            }
            Console.WriteLine(string.Join(", ", tabela));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int stevilo = VnosStevila();
            Tabeliraj1(stevilo);

        }
    }
}
