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
        public object ObradaUsluga { get; internal set; }

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

 



            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            IzbornikRadSPruzateljimaUsluga();
        }





     

        private void PrikaziSveKlijente()
        {
            var i = 0;
            Klijenti.ForEach(k => {
                Console.WriteLine(++i + ". " + k);
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
