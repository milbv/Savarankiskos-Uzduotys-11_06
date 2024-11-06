using Savarankiskos_Uzduotys_11_06.Darbuotojo_Uzduotis;
using Savarankiskos_Uzduotys_11_06.Transporto_Priemones;
using Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Contracts;
using Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Models;
using Savarankiskos_Uzduotys_11_06.Vartotoju_duomenu_analize_is_failo.Services;

namespace Savarankiskos_Uzduotys_11_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knyga knyga = new Knyga();
            knyga.GautiKnyga();
            knyga.KlasifikuotiKnyga();

            Studentas studentas = new Studentas();
            studentas.GautiStudenta();
            studentas.NustatytiIvertinima();

            Console.WriteLine("Iveskite darbuotojo tipa: (PuseEtato/PilnasEtatas)");
            string type = Console.ReadLine();
            Console.WriteLine("Iveskite darbuotojo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite atlyginima:");
            decimal atlyginimas = decimal.Parse(Console.ReadLine());
            if (type == "PilnasEtatas")
            {
                PilnasEtatas darbuotojas = new PilnasEtatas(vardas, atlyginimas);
                Console.WriteLine(darbuotojas.GautiMetiniAlyginima() + "eur");

            }
            else if (type == "PuseEtato")
            {
                PuseEtato darbuotojas = new PuseEtato(vardas, atlyginimas);
                Console.WriteLine(darbuotojas.GautiValandiniAlyginima() + "eur");

            }

            TransportoPriemone transportoPriemone;
            Console.WriteLine("Pasirinkite transporto priemone: (Automobilis/Dviratis)");
            string trPriemone = Console.ReadLine();
            Console.WriteLine("Kokiu greiciu vaziuojate? km/h");
            int greitis = int.Parse(Console.ReadLine());
            Console.WriteLine("Koki atstuma norite nuvaziuoti? km");
            int atstumas = int.Parse(Console.ReadLine());
            if (trPriemone == "Dviratis")
            {
                transportoPriemone = new Dviratis(greitis);

                Console.WriteLine($"Transporto priemone Dviratis nuvaziuos {atstumas}km per {((Dviratis)transportoPriemone).ApskaiciuotiKelionesLaika(atstumas)} valandas");
            } else if (trPriemone == "Automobilis")
            {
                transportoPriemone = new Automobilis(greitis);

                Console.WriteLine($"Transporto priemone Automobilis nuvaziuos {atstumas}km per {((Automobilis)transportoPriemone).ApskaiciuotiKelionesLaika(atstumas)} valandas");
            }
            
            string textFileLocation = "Vartotoju duomenu analize is failo/Failas.txt";
            IFailoSkaitymas fileReader = new FailoSkaitymas(textFileLocation);
            IDuomenuServisas dataService = new DuomenuServisas();
            List<string> data = fileReader.SkaitytiDuomenis(textFileLocation);
            foreach(string d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("Vidurkis: " + dataService.ApskaiciuotiVidutiniAmziu(data));
        }
    }
}
