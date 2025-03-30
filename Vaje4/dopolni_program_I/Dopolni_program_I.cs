using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopolni_program_I
{
    class Dopolni_program_I
    {
        /// <summary>
        /// Program, zahteva od uporabnika da vnese cela števila, če so števila nepravilna 
        /// vrne napako.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Z 0 nemoremo deliti, zato c nesme biti 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vnos mora biti celo število.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Število je preveliko ali premajhno");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nekaj je šlo narobe:");
                Console.WriteLine(e.ToString());
                Console.WriteLine("Popravi program, da bo to izjemo obravnaval posebej.");
            }

        }
    }
}
