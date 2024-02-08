using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class ObradaKlijent
    {
        public List<Klijent> Klijenti { get; }

        private Izbornik Izbornik;

        public ObradaKlijent(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public ObradaKlijent()
        {
            Klijenti = new List<Klijent>();
        }

        public void PrikaziIzbornik ()
        {

            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("------------>1 ->Prikaži sve klijente------------------------------");
            Console.WriteLine("------------>2 ->Dodaj klijenta<-----------------------------------");
            Console.WriteLine("------------>3 ->Uredi klijenta<-----------------------------------");
            Console.WriteLine("------------>4 ->Izbriši klijenta<---------------------------------");
            Console.WriteLine("------------>5 ->Povratak na glavni izbornik<----------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika grupa: ",
                     "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    PrikaziSveKlijente();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNovogKlijenta();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UrediKlijenta();
                    PrikaziIzbornik();
                    break;
                case 4:
                    IzbrisiKlijenta();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("------------------>Gotov rad s klijentima<-------------------------");
                    break;
            }
        }

        private void UrediKlijenta()
        {
      
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj grupe: ", "Nije dobar odabir", 1, Klijenti.Count());
            var k = Klijenti[index - 1];
            k.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi šifru klijenta (" + k.Sifra + ":  *.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            k.Usluga = PostaviUslugu();
            k.ImeKlijenta = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime klijenta (" + k.ImeKlijenta + ":  *.*.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            k.Pasmina = Pomocno.UcitajString("\"*.*.*.*.*.*.*.*.*Unesi pasminu klijenta (" + k.Pasmina + ":  *.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            k.Napomena = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi napomenu (" + k.Napomena + ":  *.*..*.*.*.*.*.*.*.*.*.*.*.*--->",
                "Unos obavezan");
            k.ImeVlasnika = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime vlasnika (" + k.ImeVlasnika + ":  .*.*.*.*.*.*.*.*.*.*.*.*--->",
                "Unos obavezan");
            k.PrezimeVlasnika = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime vlasnika (" + k.PrezimeVlasnika + ":  *.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            k.StatusRezervacije = StatusRezervacije();
  



        }



private Usluga PostaviUslugu()
        {
            Izbornik.ObradaUsluga.PrikaziSveUsluge();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj usluge: ", "Nije dobar odabir", 1, Izbornik.ObradaUsluga.Usluge.Count());
            return Izbornik.ObradaUsluga.Usluge[index - 1];
        }

        private void IzbrisiKlijenta()
        {
            PrikaziSveKlijente();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi klijenta za brisanje: .*.*.*.*.*.*.*.--->", "Nije dobar odabir", 1, Klijenti.Count());
            Klijenti.RemoveAt(index-1);
        }


        private void DodajNovogKlijenta()
        {
            var k = new Klijent();
            k.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi šifru klijenta:  *.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            k.Usluga = PostaviUslugu();
            k.ImeKlijenta = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime klijenta:  *.*.*.*.*.*.*.*.*.*.*.*.--->",
                    "Unos obavezan");
            k.Pasmina = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi pasminu klijenta:  *.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            k.ImeVlasnika = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime vlasnika:  .*.*.*.*.*.*.*.*.*.*.*.*--->",
                "Unos obavezan");
            k.PrezimeVlasnika = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime vlasnika:  *.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            k.StatusRezervacije = PostaviStatusRezervacije();
            Klijenti.Add(k);

        }

        private void PrikaziSveKlijente()
        {
            var i = 0;
            Klijenti.ForEach(k => {
                Console.WriteLine(++i + ". " + k);
            });
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");

        }

        private Usluga PostaviUslugu()
        {
            Izbornik.ObradaUsluga.PrikaziSveUsluge();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj usluge: ", "Nije dobar odabir", 1, Izbornik.ObradaUsluga.Usluge.Count());
            return Izbornik.ObradaUsluga.Usluge[index - 1];
        }

        private Usluga PostaviStatusRezervacije()
        {
            Izbornik.ObradaStatusRezervacije.PrikaziSveStatuseRezervacija();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj statusa rezervacije: ", "Nije dobar odabir", 1, Izbornik.ObradaStatusRezervacije.StatusiRezervacija.Count());
            return Izbornik.ObradaStatusRezervacije.StatusiRezervacija[index - 1];
        }

    }
}
