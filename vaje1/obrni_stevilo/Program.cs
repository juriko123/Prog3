using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrni_stevilo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi število: ");
            string stevilo = Console.ReadLine();

            if (stevilo[0] != '-')
            {
                int stevke = int.Parse(stevilo);
                Console.WriteLine(obrnjenoStevilo(stevke));
            }
            else
            {
                char minus = stevilo[0];
                int stevke = int.Parse(stevilo.Substring(1));
                Console.WriteLine(minus + obrnjenoStevilo(stevke).ToString());

            }
        }
        static int obrnjenoStevilo(int num)
        {
            int obrat = 0;
            while (num > 0)
            {
                int enice = num % 10;
                obrat = obrat * 10 + enice;
                num /= 10;
            }
            return obrat;
        }
    }
}
