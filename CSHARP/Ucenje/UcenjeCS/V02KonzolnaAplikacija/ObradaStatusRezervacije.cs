using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class ObradaStatusRezervacije
    {

        public List<StatusRezervacije> StatusiRezervacija { get; }




        public ObradaStatusRezervacije()
        {
            StatusiRezervacija = new List<StatusRezervacije>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*IZBORNIK - RAD SA STATUSIMA REZERVACIJE*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            switch (Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.Odaberi stavku izbornika:  .*.*.*.*.*.*.*.*.*.*.--->",
                "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    Console.WriteLine("------------>1 ->Prikaži sve statuse rezervacija<------------------"); ;
                    PrikaziSveStatuseRezervacija();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Dodaj status rezervacije<-------------------------");
                    DodajNoviStatusRezervacije();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.WriteLine("------------>3 ->Uredi status rezervacije<-------------------------");
                    UrediStatuseRezervacije();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("------------>4 ->Izbriši status rezervacije<-----------------------");
                    IzbrisiStatusRezervacije();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("------------------>Gotov rad sa statusima rezervacije<-------------");
                    break;
            }
        }

        private void UrediStatuseRezervacije()
        {
            PrikaziSveStatuseRezervacija();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi status rezervacije za promjenu: .*.*.--->", "Nije dobar odabir", 1, StatusiRezervacija.Count());
            var s = StatusiRezervacija[index - 1];
            s.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru (" + s.Sifra + "): .*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            s.Naziv = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjeni naziv (" + s.Naziv + "): .*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            s.Boja = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu boju (" + s.Naziv + "): .*.*.*.*.*.*.*.*.*.--->",
               "Unos obavezan");


        }

        private void IzbrisiStatusRezervacije()
        {
            PrikaziSveStatuseRezervacija();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi status rezervacije za brisanje: .*.*.--->", "Nije dobar odabir", 1, StatusiRezervacija.Count());
            StatusiRezervacija.RemoveAt(index-1);



        }

        private void DodajNoviStatusRezervacije()
        {



            var s = new StatusRezervacije();
            s.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi šifru usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            s.Naziv = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi naziv usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            s.Boja = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi boju usluge:  .*.*.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            StatusiRezervacija.Add(s);

        }

        public void PrikaziSveStatuseRezervacija()
        {
            var i = 0;
            StatusiRezervacija.ForEach(s => {
                Console.WriteLine(++i + ". " + s);
            });
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");

        }



    }
}
