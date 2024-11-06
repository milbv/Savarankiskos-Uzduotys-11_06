using Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Contracts;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Models
{
    public class FailoSkaitymas : IFailoSkaitymas
    {
        private readonly string _fileLocation;
        public FailoSkaitymas(string fileLocation)
        {
            _fileLocation = fileLocation;
            if(!_fileLocation.Contains(".txt"))
            {
                throw new Exception("Wrong file format. Expected .txt");
            }
        }

        public List<string> SkaitytiDuomenis(string failoKelias)
        {
            List<string> allData = new List<string>();
            using(StreamReader sr = new StreamReader(failoKelias))
            {
                while(!sr.EndOfStream)
                {
                    allData.Add(sr.ReadLine());
                }
                return allData;
            }
        }
    }
}
