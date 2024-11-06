using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public int PuslapiuSkaicius { get; set; }

        public Knyga (string pavadinimas, int puslapiuSkaicius)
        {
            Pavadinimas = pavadinimas;
            PuslapiuSkaicius = puslapiuSkaicius;
        }

        public Knyga()
        {
        }

        public void GautiKnyga()
        {
            Console.WriteLine("Iveskite knygos pavadinima:");
            Pavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite puslapiu skaiciu:");
            PuslapiuSkaicius = int.Parse(Console.ReadLine());
        }
        public void KlasifikuotiKnyga()
        {
            Console.Write($"Knyga {Pavadinimas} yra ");
            if (PuslapiuSkaicius < 100)
            {
                Console.WriteLine("trumpa.");
            }
            else if (PuslapiuSkaicius >= 100 && PuslapiuSkaicius <= 300)
            {
                Console.WriteLine("vidutine.");
            }
            else
            {
                Console.WriteLine("ilga.");
            }
        }
    }
}
