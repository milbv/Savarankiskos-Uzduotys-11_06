using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Transporto_Priemones
{
    public class Automobilis : TransportoPriemone
    {
        public Automobilis(int greitis)
    : base(greitis)
        {
        }
        public decimal ApskaiciuotiKelionesLaika(int atstumas)
        {
            return atstumas / Greitis;
        }
    }
}
