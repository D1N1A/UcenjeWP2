using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Polimorfizam
{

    // Polimorfizam se sastoji od OOP svojstva klasa, nasljeđivanje, učahurivanje
    // Ponašanje po OOP : klasa ima kontruktor

    internal class Program
    {

        private List<Osoba> Osobe;

        public Program()      // konstruktor 
        {
            this.Osobe = new List<Osoba>(); // pozvan je konstruktor riječju new
            NapuniListu();
            PozdraviOsobe();

        }
        public static void Izvedi ()
        {
           


            new Program();
        }

        private void NapuniListu ()
        {
            Osobe.Add(new Polaznik ()
                {
                Ime = "Marko",
                Prezime = "Kas"

            });

            Osobe.Add(new Predavac()
            {
            Ime = "Ivana",
            Prezime = "Kas"
            });

            //Polaznik je osoba zato možemo dodati listu Polaznik i Predavač u Osobu

        }

        //prvo treba napuniti listu a zatim pozdraviti
        // u Pozdravi slijedi peta petlja uz for, while, do-while i for-each
        //Lista dolazi iz system collections - ima funkcije koje omogućavaju iteraciju - funcional programing

        private void PozdraviOsobe()
        {
            //for (int i=0;i<Osobe.Count;i++)
            //{
            //Console.WriteLine(Osobe[i].Pozdravi());
            //}

            // ili 

            //foreach (osoba o in Osoba)
            //{
            //Console.WriteLine(o.Pozdravi);
            //}

            //je identično ispod Colsole.WriteLine(osoba.Pozdravi());



            Osobe.ForEach(osoba => { //Funcional programing za svaku osobu ForEach petlja pozdravi
                // Ovdje je manifestacije polimorfizma
               Console.WriteLine(osoba.Pozdravi());

            });

        }

       
    }
}
