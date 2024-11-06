using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Transporto_Priemones
{
    public class Dviratis : TransportoPriemone
    {
        public Dviratis(int greitis)
            :base (greitis)
        {
        }
        public decimal ApskaiciuotiKelionesLaika(int atstumas)
        {
            if (atstumas >= 20)
            {
                return 20 / Greitis;
            }
            return atstumas / Greitis;
        }
    }
}
