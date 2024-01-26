using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Polimorfizam
{
    internal class Grupa : Entitet
    {
        public string Naziv { get; set; }
        public Predavac Predavac { get; set; } //1. predavac tip klase 2. naziv svojstva koji se dodjeljuje
        public Smjer Smjer  { get; set; }
        public int MaksimalnoPolaznika { get; set; }
        public DateTime DatumPocetka { get; set; } //DateTime je tipa Struct

        public List <Polaznik> Polaznici { get; set; } // lista generički s nečim parametrizirana - Polaznik

        //Lista je klasa a klasa je opisnik objekta (sama klasa kaže kojeg je tipa)
        // Generics - ja ću tu klasu parametrizirat s nekim tipom
        //<T> - označava type
        // Naziv liste u množini zbog entity frameworka


        // implementirali smo sve osim Clanovi jer je to veza više na više
        // tablica clanovi nema dodatnih atributa - ne treba raditi dodatnu klasu
        // Lista je struktura podataka koja se koristi kao zamjena za nizove
        // za razliku od niza ne mora se znati veličina liste (kod niza se mora)
        // Lista je klasa za koju ne znamo s kojim tipom podatka bi htjeli raditi (može biti i miješana)

        // MVC - Model View Controler  - ovih 6 klasa koji označavaju entitete koji su Model
    }
}
