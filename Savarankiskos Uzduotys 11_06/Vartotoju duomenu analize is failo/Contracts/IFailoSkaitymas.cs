using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Contracts
{
    public interface IFailoSkaitymas
    {
        List<string> SkaitytiDuomenis(string failoKelias);
    }
}
