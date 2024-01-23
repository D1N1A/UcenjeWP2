using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi ()
        {
            //  Najčešći način deklaracije
            // umjesto Osoba osoba = new Osoba();
            Osoba osoba = new ();

            var pjevac = new Osoba();

            // pjevac.Ime= "Mirko";
            Console.WriteLine(pjevac.Ime?.Substring(0,1));


        }

        private static void E01OsnovnaSintaksa () 
        {
            // Objekt je pojavnost (instanca) klase

            Osoba osoba = new Osoba();

            osoba.Ime="Pero";
            osoba.Prezime="Perić";

            Console.WriteLine(osoba.Ime);

        }

        private static void E02DrugaSintaksa ()
        {
            Osoba o = new Osoba
            {
                Ime = Console.ReadLine(), // ovdje sam učitao ime s konzole
                Prezime = Console.ReadLine()
            };

            Console.WriteLine(o.ImePrezime());

        }

    }
}
