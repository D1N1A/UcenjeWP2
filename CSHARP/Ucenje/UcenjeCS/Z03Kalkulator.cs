using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UcenjeCS
{
    internal class Z03Kalkulator
    {
        public static void Izvedi()
        {

            Console.WriteLine("Unesi ime: ");
            string Ime1 = Console.ReadLine();

            Console.WriteLine("Unesi drugo ime: ");
            string Ime2 = Console.ReadLine();

            string Rezultat = Izracun (Ime1, Ime2);

            Console.WriteLine("Rezultat je: " + Rezultat);
        }

        static string Izracun(string Ime1, string Ime2)
        {
            return null;
        }

        static string  UkloniIstaSlova ()
        {

            return null;
        }
    }
}
