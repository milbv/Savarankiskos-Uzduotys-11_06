using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Transporto_Priemones
{
    public class TransportoPriemone
    {
        public int Greitis { get; set; }
        
        public TransportoPriemone(int greitis)
        {
            Greitis = greitis;
        }
        public TransportoPriemone()
        {
        }

    }
}
