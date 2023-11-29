using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol8TvaryTelesa
{
    internal class Ctverec : ITvar
    {
        public double A;
        public double VypocitejObsah()
        {
            return A * A;
        }

        public double VypocitejObvod()
        {
            return 4 * A;
        }

        public void ZadejHodnoty()
        {
            Console.WriteLine("Zadej stranu a [cm]: ");
            A = Convert.ToDouble(Console.ReadLine());
        }
    }
}
