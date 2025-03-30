using System;

namespace Nicle_kv_enacbe
{
    class Program
    {
        /// <summary>
        /// Vrne vse mogoče ničle kvadratne enačbe, vrne napako ob raznih primerih
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>crne v tabeli ničle kvadratne enačvbe</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static double[] NicLeKvEnacbe(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    throw new InvalidOperationException("Enacba ima neskončno ali nič rešitev.");
                }
                else
                {
                    // Linearna enačba: bx + c = 0 → x = -c / b
                    return new double[] { -c / b };
                }
            }

            // Izračun diskriminante: D = b^2 - 4ac
            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                // Dve realni rešitvi
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (D == 0)
            {
                // Eno dvojno realno rešitev
                double x = -b / (2 * a);
                return new double[] { x, x };
            }
            else
            {
                // Kompleksni rešitvi
                throw new InvalidOperationException("Enačba ima kompleksni rešitvi.");
            }
        }

        static void Test()
        {
            try
            {
                Console.WriteLine("Dve realni rešitvi: " + string.Join(", ", NicLeKvEnacbe(1, -3, 2)));
            }
            catch (Exception e) { Console.WriteLine("Napaka: " + e.Message); }

            try
            {
                Console.WriteLine("Ena dvojna realna rešitev: " + string.Join(", ", NicLeKvEnacbe(1, -2, 1)));
            }
            catch (Exception e) { Console.WriteLine("Napaka: " + e.Message); }

            try
            {
                Console.WriteLine("Kompleksne rešitve: " + string.Join(", ", NicLeKvEnacbe(1, 2, 5)));
            }
            catch (Exception e) { Console.WriteLine("Napaka: " + e.Message); }

            try
            {
                Console.WriteLine("Linearna enačba: " + string.Join(", ", NicLeKvEnacbe(0, 2, -4)));
            }
            catch (Exception e) { Console.WriteLine("Napaka: " + e.Message); }

            try
            {
                Console.WriteLine("Nesmiselna enačba): " + string.Join(", ", NicLeKvEnacbe(0, 0, 5)));
            }
            catch (Exception e) { Console.WriteLine("Napaka: " + e.Message); }
        }

        static void Main()
        {
            Test();
        }
    }
}
