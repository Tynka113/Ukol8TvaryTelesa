using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol8TvaryTelesa
{
    public class Obdelnik : ITvar
    {
        public double A;
        public double B;

        public double VypocitejObsah()
        {
            return A * B;
        }

        public double VypocitejObvod()
        {
            return 2 * (A + B);
        }

        public void ZadejHodnoty()
        {
            Console.WriteLine("Zadej stranu a [cm]: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej stranu b [cm]: ");
            B = Convert.ToDouble(Console.ReadLine());
        }
    }
}
