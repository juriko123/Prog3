using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakjluca_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int stevilo = rand.Next(100, 1000);
            Console.WriteLine(stevilo);
        }
    }
}
