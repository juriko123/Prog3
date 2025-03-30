using System;
using System.Collections.Generic;

namespace JudgingTroubles
{
    class JudgingTroubles
    {
        /// <summary>
        /// Reši nalogo Judging Troubles s Kattisa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int answers = int.Parse(Console.ReadLine());
            string[] domjudge = new string[answers];
            string[] kattis = new string[answers];

            for (int i = 0; i < answers; i++)
            {
                domjudge[i] = Console.ReadLine();
            }
            for (int i = 0; i < answers; i++)
                kattis[i] = Console.ReadLine();

            Console.WriteLine(NajvecUjemanj(FrekvenceRezultatov(domjudge), FrekvenceRezultatov(kattis)));
            Console.ReadKey();
        }


        /// <summary>
        /// Iz tabele rezultatov ocenjevanja naredi slovar, kjer so ključi različni rezultati, vrednosti pa njihove frekvence.
        /// </summary>
        /// <param name="rezultati">tabela rezultatov sodniškega sistema</param>
        /// <returns>Slovar s pari (rezultat, frekvenca).</returns>
        static Dictionary<string, int> FrekvenceRezultatov(string[] rezultati)
        {
            Dictionary<string, int> frekvence = new Dictionary<string, int>();
            foreach (string rezultat in rezultati)
            {
                if (frekvence.ContainsKey(rezultat))
                {
                    frekvence[rezultat] += 1;
                }
                else
                {
                    frekvence.Add(rezultat, 1);
                }
            }
            return frekvence;
        }

        /// <summary>
        /// Izračuna največje možno število ujemanj rezultatov dveh sodniških sistemov, shranjenih v slovarjih parov (rezultat, frekvenca).
        /// </summary>
        /// <param name="rezultati1">Slovar rezultatov enega sodniškega sistema</param>
        /// <param name="rezultati2">Slovar rezultatov drugega sodniškega sistema</param>
        /// <returns>Največje število ujemanj dveh sodniških sistemov.</returns>
        static int NajvecUjemanj(Dictionary<string, int> rezultati1, Dictionary<string, int> rezultati2)
        {
            int ujemanj = 0;
            foreach (KeyValuePair<string, int> pair in rezultati1)
            {
                if (rezultati2.ContainsKey(pair.Key))
                {
                    ujemanj += Math.Min(pair.Value, rezultati2[pair.Key]);
                }
            }
            return ujemanj;
        }
    }
}
