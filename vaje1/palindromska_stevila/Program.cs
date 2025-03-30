using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace palindromska_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi spodnjo mejo: ");
            int spodnjaMeja = int.Parse(Console.ReadLine());

            Console.Write("Vnesi zgornjo mejo: ");
            int zgornjaMeja = int.Parse(Console.ReadLine());

            List<int> palindromi = new List<int>();

            for (int i = spodnjaMeja; i <= zgornjaMeja; i++)
            {
                if (jePalindrom(i))
                {
                    palindromi.Add(i);
                }
            }
            if (palindromi.Count != 0)
            {
                Console.WriteLine($"Med {spodnjaMeja} in {zgornjaMeja} imamo naslednja palindromska stevila: {string.Join(", ", palindromi)}");
            }
            else
            {
                Console.WriteLine($"Med {spodnjaMeja} in {zgornjaMeja} ni palindromski stevil.");
            }
            
        }

        static bool jePalindrom(int num)
            //funckija z metodo dveh pointerjev preveri ali je stevilo palindrom
        {
            string stevilo = num.ToString();
            int prvi = 0;
            int zadnji = stevilo.Length - 1;
            while (prvi <= zadnji)
            {
                if (stevilo[prvi] != stevilo[zadnji])
                {
                    return false;
                }

                prvi++;
                zadnji--;
            }
            return true;
        }
    }
}
