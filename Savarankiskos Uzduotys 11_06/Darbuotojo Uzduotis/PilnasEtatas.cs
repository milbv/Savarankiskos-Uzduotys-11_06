using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Darbuotojo_Uzduotis
{
    public class PilnasEtatas : Darbuotojas
    {
        public PilnasEtatas (string vardas, decimal atlyginimas)
            :base(vardas, atlyginimas)
        {

        } 
        public decimal GautiMetiniAlyginima()
        {
            return Atlyginimas * 12;
        }
    }
}
