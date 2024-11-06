using Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Services
{
    public class DuomenuServisas : IDuomenuServisas
    {
     
        public double ApskaiciuotiVidutiniAmziu(List<string> duomenys)
        {
            string[] data = new string[2];
            List<int> nums = new List<int>();
            foreach(string s in duomenys)
            {
                data = s.Split(",");
                nums.Add(int.Parse(data[1]));
            }
            double suma = 0;
            foreach(int num in nums)
            {
                suma += num;
            }
            return suma / nums.Count();
        }
    }
}
