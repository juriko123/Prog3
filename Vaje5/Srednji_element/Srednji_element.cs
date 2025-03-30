using System;

namespace Srednji_element
{
    class Program
    {
        /// <summary>
        /// metoda vrne srednji element, če ima tabela sodo število elementov, vrne povrečje med dvema
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela">tabela vhodnih podatkov</param>
        /// <returns> srednji element</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static object Srednji<T>(T[] tabela)
        {
            if (tabela == null || tabela.Length == 0)
                throw new ArgumentException("Tabela ne sme biti prazna");

            int dolzina = tabela.Length;
            int srednjiIndex = dolzina / 2;

            if (dolzina % 2 != 0)
            {
                return tabela[srednjiIndex];
            }
            else
            {
                if (typeof(T) == typeof(int))
                {
                    int levi = Convert.ToInt32(tabela[srednjiIndex - 1]);
                    int desni = Convert.ToInt32(tabela[srednjiIndex]);
                    return (levi + desni) / 2;
                }
                else if (typeof(T) == typeof(double))
                {
                    double levi = Convert.ToDouble(tabela[srednjiIndex - 1]);
                    double desni = Convert.ToDouble(tabela[srednjiIndex]);
                    return (levi + desni) / 2.0;
                }
                else if (typeof(T) == typeof(string))
                {
                    string levi = tabela[srednjiIndex - 1].ToString();
                    string desni = tabela[srednjiIndex].ToString();
                    return levi + desni;
                }
                else
                {
                    throw new InvalidOperationException("Srednjega elementa ni mogoče dolociti za nize.");
                }
            }
        }

        static void Main()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Srednji(intArray));

            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5 };
            Console.WriteLine(Srednji(doubleArray));

            string[] stringArray = { "mačka", "pes", "zajec", "konj" };
            Console.WriteLine(Srednji(stringArray));

            object[] mixedArray = { true, false, true, false };
            Console.WriteLine(Srednji(mixedArray));
        }
    }
}
