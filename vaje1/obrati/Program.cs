using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi prvo 3-mestno število: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Vnesi drugo 3-mestno število: ");
            int num2 = int.Parse(Console.ReadLine());

            int enice1 = num1 % 10;
            int desetice1 = num1 / 10 % 10;
            int stotice1 = num1 / 100;

            int enice2 = num2 % 10;
            int desetice2 = num2 / 10 % 10;
            int stotice2 = num2 / 100;

            int stevilo1 = enice1 * 100 + desetice1 * 10 + stotice1;
            int stevilo2 = enice2 * 100 + desetice2 * 10 + stotice2;

            int res = stevilo1 - stevilo2;

            Console.WriteLine($"{stevilo1} - {stevilo2} = {res}");
        }
    }
}
