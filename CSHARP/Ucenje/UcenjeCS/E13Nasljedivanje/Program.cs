using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Program
    {
        public static void Izvedi ()
        {
            var p = new Polaznik()
            {
                Sifra = 1,
                Ime = "Pero",
                Prezime = "Perić",
                BrojUgovora = "2/2024"
            };

            //ovdje se vidi samo public
            //protected se vidi u podklasama i trenutnoj klasi

            // Zadatak: Ispisati 1 

            Console.WriteLine(p.Sifra);

            var pr1 = new Predavac();
            pr1.Ime = "Mario";

            var pr2 = new Predavac();
            pr2.Ime =  "Mario";

            Console.WriteLine((pr1==pr2) + " " +  pr1.GetHashCode() + " == " + pr2.GetHashCode());

            //var e = new Entitet(); // ne mogu instancirati abstraktnu klasu
            //e.Sifra = 2;


            // Svi nasljeđuju objekt Object a samim time i: Equals, GetHashCode, String, GetType
            // 



            string a = "Osijek";
            Console.WriteLine("a na početku: " + a.GetHashCode());

            a+= " je super";
            Console.WriteLine("a nakon promjene: " + a.GetHashCode());

            //klasa string je imutable (nepromjenjiva) svaka klasa string stvara novi string (dobije novi hashcode)

            Console.WriteLine("pr1 na početku: " + pr1.GetHashCode());
            pr1.Prezime = "Perić";
            Console.WriteLine("pr1 nakon promjene: " + pr1.GetHashCode());

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Osijek");
            Console.WriteLine("sb na početku :" + sb.GetHashCode());
            sb.AppendLine(" je super");
            Console.WriteLine("sb nakon promjene: " + sb.GetHashCode());

            Console.WriteLine(pr1);
            Console.WriteLine(p);

            var lista = new List<Polaznik>();

            //lista.Add

        }

    }
}
