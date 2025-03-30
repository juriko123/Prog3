using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Mnozimo_se
{
    /// <summary>
    /// odpremo datoteko stevila.txt in zapišemo nekaj vrednosti, vsako v svojo vrstico, nato jih preberemo in izračunamo
    /// vrednost stevca in imenovalca
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path = "stevila.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter pisi = File.CreateText(path))
                {
                    pisi.WriteLine("-2");
                    pisi.WriteLine("4/35");
                    pisi.WriteLine("52");
                    pisi.WriteLine("7/2");
                    pisi.WriteLine("-1/15");
                }
            }

            int stevec = 1;
            int imenovalec = 1;
            using (StreamReader beri = File.OpenText(path))
            {
                string vrstica = "";
                while ((vrstica = beri.ReadLine()) != null)
                {
                    if (vrstica.Contains('/'))
                    {
                        string[] stevila = vrstica.Split('/');
                        stevec = stevec * int.Parse(stevila[0]);
                        imenovalec = imenovalec * int.Parse(stevila[1]);
                    }
                    else
                    {
                        stevec = stevec * int.Parse(vrstica);
                    }
                }
            }

            Console.WriteLine($"Nas ulomek je: {stevec}/{imenovalec}");
        }
    }
}
