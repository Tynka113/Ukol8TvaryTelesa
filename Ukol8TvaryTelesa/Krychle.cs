using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol8TvaryTelesa
{
    public class Krychle : ITeleso
    {
        public double A;

        public double VypocitejObjem()
        {
            return A * A * A;
        }

        public double VypocitejPovrch()
        {
            return 6 * A * A;
        }

        public void ZadejHodnoty()
        {
            Console.WriteLine("Zadej stranu a [cm]: ");
            A = Convert.ToDouble(Console.ReadLine());
        }
    }
}
