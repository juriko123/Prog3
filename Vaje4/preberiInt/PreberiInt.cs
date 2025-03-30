using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preberiInt
{
    class PreberiInt
    {
        /// <summary>
        /// metoda sprasuje uporabnika toliko časa dokler ne vnese celega stevila
        /// </summary>
        /// <param name="sporocilo"> vprasanje ki ga postavimo uporabniku</param>
        /// <returns>vrne celo stevilo</returns>
        static int PreberiInt1(string sporocilo)
        {
           
            while (true)
            {
                Console.Write(sporocilo);
                string vnos = Console.ReadLine();
                try
                {
                    int stevilo = int.Parse(vnos); 
                    return stevilo;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"NAPAKA: {vnos} ni celo stevilo");
                }
            }
        }
        /// <summary>
        /// metoda ne deluje dokler uporabnik ne vnese pravo stevilo med spodnjo in zgornjo mejo 
        /// </summary>
        /// <param name="sporocilo"> kaj zahtevamo od uporabnika </param>
        /// <param name="spodnjaMeja"> stevilo,ki je spodnja meja</param>
        /// <param name="zgornjaMeja"> stevilo, ki je zgornja meja</param>
        /// <returns>vrne stevilo</returns>
        static int PreberiIntMeje(string sporocilo, int spodnjaMeja, int zgornjaMeja)
        {
            while (true)
            {
                int stevilo = PreberiInt1($"{sporocilo} {spodnjaMeja} in {zgornjaMeja}: ");
                if (stevilo >= spodnjaMeja && stevilo <= zgornjaMeja)
                {
                    return stevilo;
                }
                Console.WriteLine($"NAPAKA: {stevilo} ni celo število med {spodnjaMeja} in {zgornjaMeja}.");
            }
        }
        /// <summary>
        /// metoda ne deluje dokler uporabnik ne vnese pravo stevilo med spodnjo in zgornjo mejo
        /// ne deluje ce ne dolocim mej..
        /// </summary>
        /// <param name="sporocilo"> kaj zahtevamo od uporabnika </param>
        /// <param name="spodnjaMeja"> stevilo,ki je spodnja meja</param>
        /// <param name="zgornjaMeja"> stevilo, ki je zgornja meja</param>
        /// <returns>vrne stevilo</returns>
        static int PreberiIntMeje2(string sporocilo, int spodnjaMeja = -100, int zgornjaMeja = 100)
        {
            return PreberiIntMeje(sporocilo, spodnjaMeja, zgornjaMeja);
        }
        /// <summary>
        /// Meotda uprasa uporabnika po velikosti tabele, nato pa po usakem številu, na koncu ne vrne nicesar, le izpise niz te tabele
        /// </summary>
        static void VnosTabele()
        {
            int velikost = PreberiIntMeje("Vnesi stevilo elementov", 0, int.MaxValue);
            int[] tabela = new int[velikost];

            for (int i = 0; i < velikost; i++)
            {
                int stevilo = PreberiInt1($"Vnesi {i + 1}. stevilo: ");
                tabela[i] = stevilo;
            }
            
            Console.WriteLine("[" + string.Join(", ", tabela) + "]");
        }


        /// <summary>
        /// klic zgoraj navedenih metod
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //PreberiInt1
            /*string sporocilo = "Vnesi celo stevilo: ";
            int stevilo = PreberiInt1(sporocilo);
            Console.WriteLine(stevilo);*/

            //PreberiIntMeje
            /*int stevilo2 = PreberiIntMeje("Vnesi celo število med", 1, 5);
            Console.WriteLine(stevilo2);*/

            // PreberiIntMeje2
            /*int stevilo2 = PreberiIntMeje2("Vnesi celo število med");
            Console.WriteLine(stevilo2);*/

            //VnostTabele
            /*VnosTabele();*/

            
        }
    }
}
