using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proženje_napak
{
    class Nicle_kvadratne_enacbe
    {
        /// <summary>
        /// metoda spozi napake ob razlicnih a,b ,c
        /// </summary>
        /// <param name="a">vodilni člen</param>
        /// <param name="b"> člen pri x</param>
        /// <param name="c">prosti člen</param>
        /// <returns>vrne ničli kvadratne enačbe</returns>
        /// <exception cref="Exception"></exception>
        static (double, double) NKE(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        throw new Exception("Enačba ima neskončno rešitev.");
                    }
                    else
                    {
                        throw new Exception("Enačba nima rešitve.");
                    }
                }
                else
                {
                    Console.WriteLine("Linearna enačba, samo ena ničla");
                    return (-c / b, -c / b);
                }
            }

            double diskriminanta = Math.Pow(b, 2) - 4 * a * c;

            if (diskriminanta > 0)
            {
                double nicla1 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
                double nicla2 = (-b - Math.Sqrt(diskriminanta)) / (2 * a);
                return (nicla1, nicla2);
            }
            else if (diskriminanta == 0)
            {
                double nicla = -b / (2 * a);
                return (nicla, nicla);
            }
            else
            {
                throw new Exception("Enačba ima kompleksne rešitve.");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Vnesi a: ");
            int a = int.Parse(Console.ReadLine());


            Console.Write("Vnesi b: ");
            int b = int.Parse(Console.ReadLine());


            Console.Write("Vnesi c: ");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine(NKE(a, b, c));
        }
    }
}
