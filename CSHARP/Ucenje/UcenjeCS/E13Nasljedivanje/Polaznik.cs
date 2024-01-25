using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Polaznik : Osoba // Klasa Polaznik nasljeđuje sva javna i zaštićena svojstva iz klase Osoba
    {
        private int Vidim;
        public string BrojUgovora { get; set; }

        //private void ProvjeraVidljivosti ()
        //{
        //    Vidim = 2; // ovo je u mojoj klasi
        //    base.Sifra = 2; //base = u Java super --> da vidimo u nadklasi
        //    base.Vidim = 7; // ovo je u nadklasi
        //    this.Vidim = 8; // ovo je u mojoj klasi

        //    //NeVidim// se ne vidi
        //}

        public Polaznik() : base() // base ne treba eksplicitno navesti
        {
            Console.WriteLine("Konstruktor polaznika");
        }

        public Polaznik (int sifra, string ime, string prezime, string oib, string email) : base (sifra, ime, prezime, oib, email)
        {
            BrojUgovora = BrojUgovora;

        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString()).Append(" , ").Append(BrojUgovora).ToString();
        }


    }
}
