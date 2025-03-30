using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Line = Console.ReadLine().Split();
            int r1 = int.Parse(Line[0]);
            int s = int.Parse(Line[1]);
            int res = s * 2 - r1;
            Console.WriteLine(res);
        }
    }
}
