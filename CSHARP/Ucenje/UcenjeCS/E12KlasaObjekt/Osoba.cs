
using UcenjeCS.E13Nasljedivanje;

namespace UcenjeCS.E12KlasaObjekt
{
    // Klasa je opisnik objekta
   
    internal class Osoba 
    {
        // svojstva koja opisuju klasu
        public string? Ime { get; set; }
        public string Prezime { get; set; }

        public Grad Grad { get; set; }

        public string ImePrezime()
        {
            return Ime + " " + Prezime; // ovo može bolje
        }

    }
}
