using System;


namespace koliko_najvecjih
{

    class Program
    {
        /// <summary>
        /// metoda pregleda najvecji element v tabeli, in nato ga primerja z vsemi stalimi v tabeli
        /// ce so enaki poveca stevec za ena 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabela"> tabela vhodnih podatkov</param>
        /// <returns>vrne stevilo enakih elemenov</returns>
        /// <exception cref="Exception"></exception>
        public static int Najvecji<T>(T[] tabela) where T : IComparable<T>
        {
            if (tabela == null || tabela.Length == 0)
            {
                throw new Exception("Tabela ne sme biti prazna");
            }

            int stevec = 1;
            T najvecji = tabela[0];
            for (int i = 1; i < tabela.Length; i++)
            {
                if (najvecji.CompareTo(tabela[i]) < 0)
                {
                    najvecji = tabela[i];
                    stevec = 1;
                }

                else if (najvecji.CompareTo(tabela[i]) == 0)
                {
                    stevec++;
                }
            }

            return stevec;
        }
        /// <summary>
        /// metoda ce so v tabeli nizi
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns></returns>
        public static int Najvecji(string[] tabela)
        {
            int stevec = 0;
            string najdaljsi = tabela[0];

            foreach (string element in tabela)
            {
                if (element.Length > najdaljsi.Length)
                {
                    najdaljsi = element;
                    stevec = 1;
                }

                else if (najdaljsi == element)
                    stevec++;
            }

            return stevec;
            
        }
        static void Main(string[] args)
        {
            /*int[] tabela = new int[0];
            Console.WriteLine("Število najvecjih enakih elementov je: " + Najvecji(tabela));*/

            int[] tabela1 = { 1, 1, 1, 1, 1, 1, 1, 1 }; 
            Console.WriteLine("Število najvecjih enakih elementov je: " + Najvecji(tabela1));

            int[] tabela2 = { 3, 5, 7, 7, 2, 7, 1 };
            Console.WriteLine("Število najvecjih enakih elementov je: " + Najvecji(tabela2));

            string[] tabela3 = { "abeceda", "aaa", "aaaaaaa", "abeceda"};
            Console.WriteLine("Število najvecjih enakih elementov je: " + Najvecji(tabela3));


        }
    }
}
