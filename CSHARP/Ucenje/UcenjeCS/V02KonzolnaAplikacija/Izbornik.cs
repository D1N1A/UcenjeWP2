using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class Izbornik
    {

        private List<Klijent> Klijenti;
        private List<PruzateljUsluge> PruzateljiUsluga;
        private List<StatusRezervacije> StatusiRezervacija;


        public Izbornik ()
        {
            Usluge = new List<Usluga> ();
            Klijenti = new List<Klijent> ();
            PruzateljiUsluga = new List<PruzateljUsluge>();
            StatusiRezervacija = new List<StatusRezervacije> ();
            PozdravnaPoruka();
            Izbornik();

        }

        private void Izbornik()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*IZBORNIK.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("------------>1 ->Rad s uslugama<-----------------------------------");
            Console.WriteLine("------------>2 ->Rad s klijentima<---------------------------------");
            Console.WriteLine("------------>3 ->Rad s pružateljima usluga<------------------------");
            Console.WriteLine("------------>4 ->Rad sa statusima rezervacija----------------------");
            Console.WriteLine("------------>5 ->Izlaz iz programa<--------------------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            OdabirStavkePocetnogIzbornika();


        }

        private void OdabirStavkePocetnogIzbornika()
        {
            switch (V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*.*.*Unesi izbor: *.*.*.*.*.*.*.*.*.*.*.*.*.*.--->"))
            {
                case 1:
                    Console.WriteLine("------------>1 ->Rad s uslugama<-----------------------------------");
                    IzbornikRadSUslugama();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Rad s klijentima<---------------------------------");
                    IzbornikRadSKlijentima();
                    break;  
                case 3:
                    Console.WriteLine("------------>3 ->Rad s pružateljima usluga<------------------------");
                    break;
                    IzbornikRadSPruzateljimaUsluga();
                case 4:
                    Console.WriteLine("------------>4 ->Rad sa statusima rezervacija----------------------");
                    break;
                    IzbornikRadSaStatusimaRezervacije();
                case 5:
                    Console.WriteLine("------------>5 ->Izlaz iz programa<--------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("-------------->1 ->Krivi odabir<------------------------------------");
                    Izbornik();
                    break;
            }
         
        }

        private void IzbornikRadSaStatusimaRezervacije()
        {
            throw new NotImplementedException();
        }

        private void IzbornikRadSPruzateljimaUsluga()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("------------>1 ->Prikaži sve pružatelje usluga---------------------");
            Console.WriteLine("------------>2 ->Dodaj pružatelja usluge<--------------------------");
            Console.WriteLine("------------>3 ->Uredi pružatelja usluge<--------------------------");
            Console.WriteLine("------------>4 ->Izbriši pružatelja usluge<------------------------");
            Console.WriteLine("------------>5 ->Povratak na glavni izbornik<----------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            OdabirStavkeIzbornikPruzateljaUsluge();
        }

        private void OdabirStavkeIzbornikPruzateljaUsluge()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*IZBORNIK - RAD S PRUŽATELJIMA USLUGA*.*.**.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            switch (V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.Odaberi stavku izbornika:  .*.*.*.*.*.*.*.*.*.*.--->"))
            {
                case 1:
                    Console.WriteLine("------------>1 ->Prikaži sve pružatelje usluga<--------------------"); ;
                    PrikaziSvePruzateljeUsluga();
                    IzbornikRadSPruzateljimaUsluga();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Dodaj pružatelja usluge<--------------------------");
                    DodajNovogPruzateljaUsluga();
                    break;
                case 3:
                    Console.WriteLine("------------>3 ->Uredi pružatelja usluge<--------------------------");
                    UrediPruzateljaUsluge();
                    break;
                case 4:
                    Console.WriteLine("------------>4 ->Izbriši pružatelja usluge<------------------------");
                    IzbrisiPruzateljaUsluge();
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("------------------>Krivi odabir<------------------------------------");
                    IzbornikRadSPruzateljimaUsluga();
                    break;
            }
        }

        private void IzbrisiPruzateljaUsluge()
        {
            PrikaziSvePruzateljeUsluga();
            PruzateljiUsluga.RemoveAt(V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi pružatelja usluge za brisanje: *.*.*.--->") -1);
            IzbornikRadSPruzateljimaUsluga();
        }

        private void UrediPruzateljaUsluge()
        {
            PrikaziSvePruzateljeUsluga();
            var p = PruzateljiUsluga[V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi pružatelja usluge za promjenu: *.*.*.*.*.--->") - 1];
            p.Sifra = V02KonzolnaAplikacija.Pomocno.UcitajInt(p.Sifra +  "*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru: .*.*.*.*.*.*.*.*.*.--->");
            p.Ime = V02KonzolnaAplikacija.Pomocno.UcitajString(p.Ime + "*.*.*.*.*.*.*.*.*Unesi promijenjeno ime pružatelja usluge: .*.--->");
            p.Prezime = V02KonzolnaAplikacija.Pomocno.UcitajString(p.Prezime + "*.*.*.*.*.*.*.*.*Unesi promijenjeno prezime pružatelja usluge:--->");
            p.Adresa = V02KonzolnaAplikacija.Pomocno.UcitajString(p.Adresa +"*.*.*.*.*.*.*.*.*Unesi promijenjenu adresu pružatelja usluge: --->");
            IzbornikRadSPruzateljimaUsluga();
        }

        private void DodajNovogPruzateljaUsluga()
        {
            PruzateljiUsluga.Add(new PruzateljUsluge()
            {
                Sifra = V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Unesi šifru pružatelja usluge:  .*.*.*.*.*.*.--->"),
                Ime = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime pružatelja usluge:  .*.*.*.*.*.*.*.--->"),
                Prezime = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime pružatelja usluge:  .*.*.*.*.*.--->"),
                Adresa = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime pružatelja usluge:  *.*.*.*.*.*.--->")
            });




            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            IzbornikRadSPruzateljimaUsluga();
        }

        private void PrikaziSvePruzateljeUsluga()
        {
            var i = 0;
            PruzateljiUsluga.ForEach(p => {
                Console.WriteLine(++i + ". " + p);
            });
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*"); ;
        }

        private void IzbornikRadSKlijentima()
        {
          
                Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
                Console.WriteLine("------------>1 ->Prikaži sve klijente------------------------------");
                Console.WriteLine("------------>2 ->Dodaj klijenta<-----------------------------------");
                Console.WriteLine("------------>3 ->Uredi klijenta<-----------------------------------");
                Console.WriteLine("------------>4 ->Izbriši klijenta<---------------------------------");
                Console.WriteLine("------------>5 ->Povratak na glavni izbornik<----------------------");
                Console.WriteLine("-------------------------------------------------------------------");
                OdabirStavkeIzbornikKlijenta();
            }


        private void IzbrisiKlijenta()
        {
            PrikaziSveKlijente();
            Usluge.RemoveAt(V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi klijenta za brisanje: .*.*.*.*.*.*.*.--->") -1);
            IzbornikRadSUslugama();
        }

     

        private void PrikaziSveKlijente()
        {
            var i = 0;
            Klijenti.ForEach(k => {
                Console.WriteLine(++i + ". " + k);
            });
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");

        }

        private void DodajNovogKlijenta()
        {
            Klijenti.Add(new Klijent() { 
                Sifra = V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Unesi šifru klijenta:  *.*.*.*.*.*.*.*.*.*.*.--->"), 
                ImeKlijenta = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime klijenta:  *.*.*.*.*.*.*.*.*.*.*.*.--->"), 
                Pasmina = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi pasminu klijenta:  *.*.*.*.*.*.*.*.*.*.--->"), 
                Napomena = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi napomenu:  *.*..*.*.*.*.*.*.*.*.*.*.*.*--->"), 
                ImeVlasnika = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi ime vlasnika:  .*.*.*.*.*.*.*.*.*.*.*.*--->"), 
                PrezimeVlasnika = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi prezime vlasnika:  *.*.*.*.*.*.*.*.*.*.--->") 
            });




            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            IzbornikRadSKlijentima();
        }

        private void IzbornikRadSUslugama()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("------------>1 ->Prikaži sve usluge<-------------------------------");
            Console.WriteLine("------------>2 ->Dodaj uslugu<-------------------------------------");
            Console.WriteLine("------------>3 ->Uredi uslugu<-------------------------------------");
            Console.WriteLine("------------>4 ->Izbriši uslugu<-----------------------------------");
            Console.WriteLine("------------>5 ->Povratak na glavni izbornik<----------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            OdabirStavkeIzbornikUsluge();
        }

        private void OdabirStavkeIzbornikUsluge()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*IZBORNIK - RAD S USLUGAMA*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            switch (V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.Odaberi stavku izbornika:  .*.*.*.*.*.*.*.*.*.*.--->"))
            {
                case 1:
                    Console.WriteLine("------------>1 ->Prikaži sve usluge<-------------------------------"); ;
                    PrikaziSveUsluge();
                    IzbornikRadSUslugama();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Dodaj uslugu<-------------------------------------");
                    DodajNovuUslugu();
                    break;
                case 3:
                    Console.WriteLine("------------>3 ->Uredi uslugu<-------------------------------------");
                    UrediUslugu();
                    break;
                case 4:
                    Console.WriteLine("------------>4 ->Izbriši uslugu<-----------------------------------");
                    IzbrisiUslugu();
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("------------------>Krivi odabir<------------------------------------");
                    IzbornikRadSUslugama();
                    break;
            }
        }

        private void IzbrisiUslugu()
        {
            PrikaziSveUsluge();
            Usluge.RemoveAt(V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi uslugu za brisanje: .*.*.*.*.*.*.*.*.--->") -1);
            IzbornikRadSUslugama();
        }

        private void UrediUslugu()
        {
            PrikaziSveUsluge();
            var u = Usluge[V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi uslugu za promjenu: .*.*.*.*.*.*.*.*.--->") - 1];
            u.Sifra = V02KonzolnaAplikacija.Pomocno.UcitajInt(u.Sifra +  "*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru: .*.*.*.*.*.*.*.*.*.--->");
            u.Naziv = V02KonzolnaAplikacija.Pomocno.UcitajString(u.Naziv +"*.*.*.*.*.*.*.*.*Unesi promijenjeni naziv: .*.*.*.*.*.*.*.*.*.--->");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            IzbornikRadSUslugama();

        }

        private void DodajNovuUslugu()
        {
            Usluge.Add(new Usluga()
            {
                Sifra = V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Unesi šifru usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->"),
                Naziv = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi naziv usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->")
            });

            

            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            IzbornikRadSUslugama();
        }

        private void PrikaziSveUsluge()
        {
            var i = 0;
            Usluge.ForEach(u => {
                Console.WriteLine(++i + ". " + u);
            });
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");

        }


        private void PozdravnaPoruka()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*USLUGE ZA KUĆNE LJUBIMCE APLIKACIJA V1 *.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
        }
    }
}
