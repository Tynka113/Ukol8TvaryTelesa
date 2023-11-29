using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol8TvaryTelesa
{
    public class Kvadr : ITeleso
    {
        public double A;
        public double B;
        public double C;

        public double VypocitejObjem()
        {
            return A * B * C;
        }

        public double VypocitejPovrch()
        {
            return 2*((A * B) + (B * C) + (A * C));
        }

        public void ZadejHodnoty()
        {
            Console.WriteLine("Zadej stranu a [cm]: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej stranu b [cm]: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej stranu c [cm]: ");
            C = Convert.ToDouble(Console.ReadLine());
        }
    }
}
