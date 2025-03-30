using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica
{
    class Program
    {
        public class Kosarica<T>
        {
            private T vsebina;


            public T Vsebina
            {
                get { return this.vsebina; }
                set { this.vsebina = value; }
            }

            public Kosarica(T element)
            {
                this.Vsebina = element;
            }
            public override string ToString()
            {
                if (this.vsebina == null)
                    throw new Exception("Vsebina ne sme biti prazna");


                else if (this.vsebina is Array array)
                {
                    return "[" + string.Join(", ", array.Cast<object>()) + "]";
                }

                else
                    return this.vsebina.ToString();
            }
        }

        public class Zajec
        {
            private string ime;
            private int starost;

            public string Ime
            {
                get { return ime;}
                set
                {
                    if (value == null || value.Length == 0)
                        throw new Exception("Zajec ne sme biti brez imena.");
                    ime = value;
                }

            }

            public int Starost
            {
                get { return starost; }
                set
                {
                    if (value < 0)
                        throw new Exception("Zajec ne more imeti negativnih let");
                    starost = value;
                }
            }

            public Zajec(string ime, int starost)
            {
                this.Ime = ime;
                this.Starost = starost;
            }

            public override string ToString()
            {
                return $"Ime zajca: {this.ime} in njegova starost: {this.starost}";
            }


        }
        static void Main(string[] args)
        {
            Kosarica<string> niz = new Kosarica<string>("Dober dan");
            Console.WriteLine(niz.ToString());

            Kosarica<int> stevilo = new Kosarica<int>(1);
            Console.WriteLine(stevilo.ToString());

            Kosarica<double> realno_stevilo = new Kosarica<double>(3.14);
            Console.WriteLine(realno_stevilo.ToString());

            Zajec nekdo = new Zajec("Tone", 10);
            Kosarica<Zajec> objekt = new Kosarica<Zajec>(nekdo);
            Console.WriteLine(objekt.ToString());

            Kosarica<int[]> tabela_stevil = new Kosarica<int[]>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(tabela_stevil.ToString());

            Kosarica<string[]> tabela_nizov = new Kosarica<string[]>(new string[] { "Dober", "dan", "Jurij" });
            Console.WriteLine(tabela_nizov.ToString());

        }
    }
}
