using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace presledki
{
    class Program
    {
        static string brezPresledkov(string beseda)
        {
            char[] presledek = {' '};
            string nova_beseda = "";
            for (int i = 0; i < beseda.Length; i++)
            {
                if (!(beseda[i] == presledek[0]))
                {
                    nova_beseda += beseda[i];
                }
            }

            return nova_beseda;
        }

        static int steviloPresledkov(string beseda)
        {
            char[] presledek = { ' ' };
            int stevec = 0;
            for (int i = 0; i < beseda.Length; i++)
            {
                if (beseda[i] == presledek[0])
                {
                    stevec += 1;
                }
            }

            return stevec;
        }

        static string niz(string beseda)
        {
            // funckija vrne niz brez zacetnih koncnih in zaporednih nizov, ce bi zeleli z zacetnim in koncnim presledkom samo ne bi 
            // uporabili metode Trim.
            beseda = beseda.Trim(); // odstrani zacetne in koncne presledke 


            //nalogo lahko resimo z 2 pointers
            char[] crke = beseda.ToCharArray();
            int pointer = 0;
            bool presledek = true;

            for (int i = 0; i < beseda.Length; i++)
            {
                if (crke[i] != ' ')
                {
                    crke[pointer++] = crke[i];
                    presledek = false;
                }
                else if (!presledek)
                {
                    crke[pointer++] = ' ';
                    presledek = true;
                }
            }

            return new string(crke, 0, pointer);
        }

        static int stBesed(string beseda)
        {
            string[] besede = beseda.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return besede.Length;
        }

        static string[] KatereBesed(string beseda)
        {
            string[] besede = beseda.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return besede;
        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi niz: ");   
            string beseda = Console.ReadLine();
            string brez_presledkoa = brezPresledkov(beseda);
            int stevilo_presledkov = steviloPresledkov(beseda);
            string nizz = string.Join(",",niz(beseda));
            int steviloBesed = stBesed(beseda);
            string[] katere_besede = KatereBesed(beseda);
            
            Console.Write("Niz brez presledkov: ");
            Console.WriteLine(brez_presledkoa);
            
            Console.Write("število presledkov v nizu: ");
            Console.WriteLine(stevilo_presledkov);
            
            Console.Write("niz brez koncnih,zacetnih in zaporednih presledkov: ");
            Console.WriteLine(nizz);
            
            Console.Write("Število besed v nizu je: ");
            Console.WriteLine(steviloBesed);

            Console.WriteLine("Besede v nizu so: ");
            for (int i = 0; i < katere_besede.Length; i++)
            {
                Console.WriteLine($"{i+1}. beseda: {katere_besede[i]}");

            }




        }
    }
}
