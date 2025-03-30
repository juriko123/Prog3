using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goljufivi_pek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi predpisano težo hlebca: ");
            double tezaPredpis = double.Parse(Console.ReadLine());
            Console.Write("Vnesi število hlebcev v pekarni: ");
            int steviloHlebcev = int.Parse(Console.ReadLine());
            int stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;
            double maxTeza = tezaPredpis * 1.2;
            for (int i = 1; i <= steviloHlebcev; i++)
            {
                Console.Write("Vnesi težo: " + i.ToString() + ". hlebca: ");
                double dejanskaTeza = double.Parse(Console.ReadLine());
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) || (dejanskaTeza > maxTeza))
                    stevecNapacnih++;
            }
            //računamo ali bo pek pil vodo
            if (stevecNapacnih > steviloHlebcev * 0.15)
                Console.WriteLine("Peka se bo namakal.");
            else
                Console.WriteLine("Pek ima dobro mero.");
            Console.ReadKey();
        }
    }
}
