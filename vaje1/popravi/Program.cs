using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popravi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi 3 stevila: ");
            String a = Console.ReadLine(); // int a = int.Parse(Console.ReadLine());
            String b = Console.ReadLine(); // int b = int.Parse(Console.ReadLine());
            String c = Console.ReadLine(); // int c = int.Parse(Console.ReadLine());

            int num1 = int.Parse(a);
            int num2 = int.Parse(b);
            int num3 = int.Parse(c);

            Console.WriteLine("Za števila a, b in c seveda velja a+(b+c)=(a+b)+c, saj je " + (num1 + (num2 + num3)) + "=" + ((num1 + num2) + num3) + ".");
            Console.WriteLine($"Za števila a, b in c seveda velja a + (b + c) = (a + b) + c, saj je {num1} + ({num2} + {num3}) = ({num1} + {num2}) + {num3}.");
        }
    }
}
