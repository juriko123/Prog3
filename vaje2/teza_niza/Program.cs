using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teza_niza
{
    class Program
    {
        static int tezaNiza(string beseda)
        {
            string slovenskaMala = "abcčdefghijklmnoprsštuvzž"; //1-25
            string slovenskaVelika = "ABCČDEFGHIJKLMNOPRSŠTUVZŽ"; // 51-75
            int dolzinaBesede = beseda.Length;
            //najprej pretvorimo niz v nit v katerem so le crke: "Dober dan" -> "Doberdan"
            string skupajNiz = "";
            for (int i = 0; i < dolzinaBesede; i++)
            {
                if (slovenskaMala.Contains(beseda[i]) || slovenskaVelika.Contains(beseda[i]))
                    skupajNiz += beseda[i];
            }
            // izracunamo tezo niza, v neko tabelo si bomo shranjevali indexe crk
            int[] tabIndexi = new int[beseda.Length];
            int dolzinaSkupajNiza = skupajNiz.Length;
            int vrednost = 0;
            for (int i = 0; i < dolzinaSkupajNiza; i++ )
            {
                if (slovenskaMala.Contains(skupajNiz[i]))
                {
                    vrednost += slovenskaMala.IndexOf(skupajNiz[i]) + 1;
                    tabIndexi[i] = slovenskaMala.IndexOf(skupajNiz[i]);
                }

                else
                {
                    vrednost += slovenskaVelika.IndexOf(skupajNiz[i]) + 51;
                    tabIndexi[i] = slovenskaVelika.IndexOf(skupajNiz[i]);
                }
             
            }
            string racun = String.Join(" + ", tabIndexi);

            return vrednost;
        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi niz: ");
            string niz = Console.ReadLine();

            Console.WriteLine("Tehtnica: Slovenska");

            int teza = tezaNiza(niz);
            Console.WriteLine("Teža niza: " + teza);


        }
    }
}
