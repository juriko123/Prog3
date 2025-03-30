using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_gore
{
    class Vgore
    {
        const double g = 9.8; //definiramo globalno spremenljivko
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Vnesi cas padanja kamna z mostu do tal (v sekundah): ");
            double t = Double.Parse(Console.ReadLine());
            Console.WriteLine("Visina : " + VisinaMostu(t) + " m.");
        }

        /// <summary>
        /// izračuna višino mostu in ga zaokroži na dve decimalki
        /// </summary>
        /// <param name="t"> Referenca na čas padanja </param>
        /// <returns> vrne višino mostu zaokroženo na dve decimalki</returns>
        public static double VisinaMostu(double t)
        {
            //izracunamo visino 
            double h = (g * Math.Pow(t,2)) / 2;
            //zaokrozimo na dve decimalki 
            h = (h * 100) / 100.0;
            return h;
        }
    }
}
