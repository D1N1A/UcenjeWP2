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
            Osoba o = new Osoba ();

            Grad g = new()
            {
                //Naziv = "Osijek",
                BrojStanovnika = 100000
            };

            o.Grad = g;

            Console.Write(g.Naziv);

            // kako ću na instanci klase Oba ispisati Osijek
            Console.WriteLine(o.Grad?.Naziv);

      
        }

        private static string Unos (string poruka)
        {
            string unos;
            while (true)
            {
                Console.Write(poruka);
                unos = Console.ReadLine();
                if (unos.Trim().Length == 0)
                {
                    Console.WriteLine("Unos obavezam");
                    continue;
                }
                return unos;
            }

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

        private static void E03Najcesce ()
        {
            //  Najčešći način deklaracije
            // umjesto Osoba osoba = new Osoba();
            Osoba osoba = new();

            var pjevac = new Osoba();

            // pjevac.Ime= "Mirko";
            Console.WriteLine(pjevac.Ime?.Substring(0, 1));



        }

       private static void E04Kalkuator ()
        {
            Kalkulator kalkulator = new (); // s new se poziva konstruktor
            //Console.Write("Unesi ime prve osobe: ");
            //Kalkulator.PrvoIme = Console.ReadLine();

            kalkulator.PrvoIme = Unos("Unesi ime prve osobe: ");
        kalkulator.DrugoIme = Unos("Unesi ime druge osobe: ");

        Console.WriteLine(kalkulator.Rezultat());

            Console.WriteLine(new Kalkulator(Unos("PI"),Unos("DI")).Rezultat());

        }

}
}
