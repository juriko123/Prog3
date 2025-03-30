using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deljiva_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi spodnjo mejo: ");
            int spodnjaMeja = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zgornjo mejo: ");
            int zgornjaMeja = int.Parse(Console.ReadLine());

            List<int> stevke = new List<int>(); // ustvari seznam kakor v pythonu
            
           
            for (int i = spodnjaMeja; i <= zgornjaMeja; i++)
            {
                if (i % vsotaStevk(i) == 0)
                {
                    stevke.Add(i);
                }
            }

            Console.WriteLine($"Med {spodnjaMeja} in {zgornjaMeja} so z vsoto svojih števk deljiva naslednja števila: {string.Join(", ", stevke)}");
        }
        

        static int vsotaStevk(int num)
            //sprejme stevilo in izracuna vsoto njegovih stevk
        {
            int vsota = 0;
            while (num > 0)
            {
                vsota += num % 10;
                num /= 10;
            }
            return vsota;
        }
    }
}
