using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace caramo_s_celimi_stevili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo število: ");
            int stevec= int.Parse(Console.ReadLine());
            Console.Write("Vnesi drugo število: ");
            int imenovalec = int.Parse(Console.ReadLine());
            Console.Write("Vnesi na koliko decimalk naj zaokrožim: ");
            int decimalke = int.Parse(Console.ReadLine());
            
            int ostanek = stevec % imenovalec;
            int count = 0;
            String decimalnaVejica = ".";
            int celiDel = stevec / imenovalec;
            
            while (count < decimalke)
            {
                ostanek = ostanek * 10;
                int nd = ostanek / imenovalec;
                decimalnaVejica = decimalnaVejica + nd.ToString();
                count = count + 1;
                ostanek = ostanek % imenovalec;

            }

            Console.WriteLine(celiDel.ToString() + decimalnaVejica);

        }
    }
}
