using System;

namespace goljufivi_pek
{
    class Program
    {

        static double[] tezaHlebcev(int steviloHlebcev)
        {
            double[] hlebci = new double[steviloHlebcev];
            for (int i = 1; i <= steviloHlebcev; i++)
            {
                Console.Write("Vnesi tezo: " + i + ". hlebca ");
                hlebci[i - 1] = double.Parse(Console.ReadLine());
            }
            return hlebci;
        }
        static void izpis(double tezaPredpis, double[] hlebci)
        {
            int stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;
            double maxTeza = tezaPredpis * 1.2;
            for (int i = 1; i <= hlebci.Length; i++)
            {
                double dejanskaTeza = hlebci[i - 1];
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) || (dejanskaTeza > maxTeza))
                {
                    stevecNapacnih++;
                }
            }
            //računamo ali bo pek pil vodo
            if (stevecNapacnih > hlebci.Length * 0.15)
                Console.WriteLine("Peka v vodo takoj!!!!");
            else
                Console.WriteLine("Pek ima dobro mero");

        }
        

        static void Main(string[] args)
        {
            Console.Write("Vnesi predpisano tezo hlebca: ");
            double tezaPredpis = double.Parse(Console.ReadLine());
            Console.Write("Vnesi stevilo hlebcev v pekarni: ");
            int steviloHlebcev = int.Parse(Console.ReadLine());

            double[] hlebci = tezaHlebcev(steviloHlebcev);
            izpis(tezaPredpis, hlebci);
            
        }
    }
}



