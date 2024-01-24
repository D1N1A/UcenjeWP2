
using System.Text;

namespace UcenjeCS.E13Nasljedivanje
{
    internal abstract class Osoba : Entitet // Internal ekvivalent packagescope koja se ne mora pisati u javi
    {
        private int neVidim; //samo u klasi
        protected int Vidim; //samo u podklasama

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public string Email { get; set; }

        public Osoba()
            {
            Console.WriteLine("Konstruktor osoba");
            }

        public Osoba (int sifra, string ime, string prezime, string oib, string email) : base (sifra)
        {

        }

        public override string ToString()
        {
            //return Ime + " " + Prezime;
            return new StringBuilder(Ime).Append(Prezime).ToString();
        }
    }
}
}
