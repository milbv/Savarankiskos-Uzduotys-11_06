using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskos_Uzduotys_11_06
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int Pazymys { get; set; }

        public Studentas(string vardas, int pazymys)
        {
            Vardas = vardas;
            Pazymys = pazymys;
        }
        public Studentas()
        {
        }
        public void GautiStudenta()
        {
            Console.WriteLine("Iveskite Varda:");
            Vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pazymi:");
            Pazymys = int.Parse(Console.ReadLine());
        }

        public void NustatytiIvertinima()
        {
            if(Pazymys >= 1 && Pazymys < 4)
            {
                Console.WriteLine("Neislaike");
            } else if (Pazymys >= 4 && Pazymys <= 6)
            {
                Console.WriteLine("Patenkinamas");
            } else if (Pazymys >= 7 && Pazymys <= 8)
            {
                Console.WriteLine("Geras");
            } else if (Pazymys >= 9 && Pazymys <= 10)
            {
                Console.WriteLine("Labai geras");
            } else
            {
                Console.WriteLine("Netinkamas pazymys");
            }
        }
    }
}
