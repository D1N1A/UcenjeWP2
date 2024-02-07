using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class ObradaPruzateljUsluge
    {
        public List<PruzateljUsluge> PruzateljiUsluga { get; }

        private Izbornik Izbornik;

        public ObradaPruzateljUsluge(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public ObradaPruzateljUsluge()
        {
            PruzateljiUsluga = new List<PruzateljUsluge>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*IZBORNIK - RAD S PRUŽATELJIMA USLUGA*.*.**.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika smjera: ",
                "Odabir mora biti 1-5", 1, 5))
            { 
                case 1:
                    Console.WriteLine("------------>1 ->Prikaži sve pružatelje usluga<--------------------"); ;
                    PrikaziSvePruzateljeUsluga();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Dodaj pružatelja usluge<--------------------------");
                    DodajNovogPruzateljaUsluga();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.WriteLine("------------>3 ->Uredi pružatelja usluge<--------------------------");
                    UrediPruzateljaUsluge();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("------------>4 ->Izbriši pružatelja usluge<------------------------");
                    IzbrisiPruzateljaUsluge();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("------------------>Gotov rad s pružateljima usluga<----------------");
                    break;
            }

        }

        private void UrediPruzateljaUsluge()
        {

            PrikaziSvePruzateljeUsluga();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi pružatelja usluge za promjenu: .*.*.*.--->", "Nije dobar odabir", 1, PruzateljiUsluga.Count());
            var p = PruzateljiUsluga[index - 1];
            p.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru (" + p.Sifra + "): .*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            p.Fotografija = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu fotografiju (" + p.Fotografija + "): *.--->",
                "Unos obavezan");
            p.Adresa = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu adresu (" + p.Adresa + "): *.*.*.--->",
               "Unos obavezan");
            p.Email = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu eMail (" + p.Email + "): .*.*.*.--->",
             "Unos obavezan");

        }

        private void IzbrisiPruzateljaUsluge()
        {
            PrikaziSvePruzateljeUsluga();
            PruzateljiUsluga.RemoveAt(Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi pružatelja usluge za brisanje: *.*.*.--->") -1);

        }

        private void DodajNovogPruzateljaUsluga()
        {
            PrikaziSvePruzateljeUsluga();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi pružatelja usluge za promjenu: .*.*.*.--->", "Nije dobar odabir", 1, PruzateljiUsluga.Count());
            var p = PruzateljiUsluga[index - 1];
            p.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru (" + p.Sifra + "): .*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            p.Fotografija = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu fotografiju (" + p.Fotografija + "): *.--->",
                "Unos obavezan");
            p.Adresa = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu adresu (" + p.Adresa + "): *.*.*.--->",
               "Unos obavezan");
            p.Email = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjenu eMail (" + p.Email + "): .*.*.*.--->",
             "Unos obavezan");

        }


        private void PrikaziSvePruzateljeUsluga()
            {
                var i = 0;
                PruzateljiUsluga.ForEach(p => {
                    Console.WriteLine(++i + ". " + p);
                });
                Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*"); ;
            }




        }
    }
