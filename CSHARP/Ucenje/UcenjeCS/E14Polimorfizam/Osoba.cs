using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Polimorfizam
{
    internal abstract class Osoba : Entitet
    {
        public abstract string Pozdravi(); // nema vitičastih znači abstraktna - tko ju nasljedi mora primjeniti tu metodu
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string  Oib { get; set; }
        public string Email { get; set; }

        //Primjer metoda pozdravi: svaku osobu moramo pozdraviti, kako to će odraditi Polaznik, Predavac
        //ako se ne primjeni u nižim klasama pokazuje grešku
    }
}
