using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Darbuotojo_Uzduotis
{
    public class PuseEtato : Darbuotojas
    {
        public PuseEtato(string vardas, decimal atlyginimas)
    : base(vardas, atlyginimas)
        {

        }
        public decimal GautiValandiniAlyginima()
        {
            return Atlyginimas * 160;
        }
    }
}
