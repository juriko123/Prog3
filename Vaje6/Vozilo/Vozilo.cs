using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    class Vozilo
    {
        private double gorivo;
        private double kapaciteta;
        private double poraba;

        public double Gorivo
        {
            get { return gorivo;}
            set
            {
                if (value < 0 ||value > kapaciteta)
                    throw new Exception("Gorivo ne sme biti manjse od 0 ali večje od kapacitete.");
                gorivo = value;
            }
        }

        public double Poraba
        {
            get { return poraba; }
            set
            {
                if (value < 0)
                    throw new Exception("Poraba ne sme biti manjsa od 0.");
                poraba = value;
            }
        }

        public double Kapaciteta
        {
            get { return kapaciteta; }
            set
            {
                if (value < 0)
                    throw new Exception("Kapaciteta ne sme biti manjsa od 0.");
                kapaciteta = value;
            }
        }

        public Vozilo(double kapaciteta, double poraba)
        {
            this.Kapaciteta = kapaciteta;
            this.Poraba = poraba;
            this.Gorivo = kapaciteta;
        }

        public double PreostaliKilometri
        {
            get { return (gorivo / poraba) * 100; }
            
        }

        public void Crpalka()
        {
            gorivo = kapaciteta;
            Console.WriteLine("Polno");
        }

        public bool Pot(double[] tabela_poti)
        {
            if (tabela_poti == null || tabela_poti.Length == 0)
                throw new Exception("V dani tabeli ni nobene poti.");

            double tempgorivo = gorivo;
            
            for (int i=0; i<tabela_poti.Length; i++)
            {
                if (tabela_poti[i] < 0)
                    throw new Exception("Pot ne sme biti negativna.");

                if (i > 0 && tabela_poti[i] == 0 && tabela_poti[i - 1] == 0)
                    throw new Exception("Pot ne sme biti dvakrat zapored 0.");

                if (tabela_poti[i] == 0)
                    Crpalka();

                else
                {
                    double potrebno_gorivo = (tabela_poti[i] / 100) * poraba;

                    if (potrebno_gorivo > gorivo)
                    {
                        gorivo = tempgorivo;
                        return false;
                    }
                    gorivo -= potrebno_gorivo;


                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avto = new Vozilo(26, 5);
            double koliko = avto.PreostaliKilometri;
            Console.WriteLine($"Koliko km lahko se prevozim: {koliko}km");
            avto.Crpalka();

            double[] poti = {200, 100};

            if (avto.Pot(poti))
                Console.WriteLine("Lahko prevozimo");
            else
                Console.WriteLine("Nemoremo");
            Console.WriteLine($"V avtu je preostalo se: {avto.Gorivo}L");
        }
    }
}





