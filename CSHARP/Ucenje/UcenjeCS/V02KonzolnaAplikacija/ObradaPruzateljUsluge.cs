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
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj smjera: ", "Nije dobar odabir", 1, PruzateljiUsluga.Count());
            var p = PruzateljiUsluga[index - 1];
            p.Sifra = Pomocno.ucitajCijeliBroj(p.Sifra +  "*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru: .*.*.*.*.*.*.*.*.*.--->",);
            p.Ime = Pomocno.UcitajString(p.Ime + "*.*.*.*.*.*.*.*.*Unesi promijenjeno ime pružatelja usluge: .*.--->",);
            p.Prezime = Pomocno.UcitajString(p.Prezime + "*.*.*.*.*.*.*.*.*Unesi promijenjeno prezime pružatelja usluge:--->",);
            p.Adresa = Pomocno.UcitajString(p.Adresa +"*.*.*.*.*.*.*.*.*Unesi promijenjenu adresu pružatelja usluge: --->",);

        }

        private void IzbrisiPruzateljaUsluge()
        {
            PrikaziSvePruzateljeUsluga();
            PruzateljiUsluga.RemoveAt(Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi pružatelja usluge za brisanje: *.*.*.--->") -1);

        }

        private void DodajNovogPruzateljaUsluga()
        {
            PruzateljiUsluga.Add(new PruzateljUsluge()
            {
                Sifra = Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Unesi šifru pružatelja usluge:  .*.*.*.*.*.*.--->"),
                Ime = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime pružatelja usluge:  .*.*.*.*.*.*.*.--->"),
                Prezime = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime pružatelja usluge:  .*.*.*.*.*.--->"),
                Adresa = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime pružatelja usluge:  *.*.*.*.*.*.--->")
            });
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
