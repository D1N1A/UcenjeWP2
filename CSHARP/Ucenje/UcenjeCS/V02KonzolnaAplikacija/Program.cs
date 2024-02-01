using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class Program
    {
        private List<Usluga> Usluge;


        public Program ()
        {
            Usluge = new List<Usluga> ();
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
            switch (Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*.*.*Unesi izbor: *.*.*.*.*.*.*.*.*.*.*.*.*.*.--->"))
            {
                case 1:
                    Console.WriteLine("------------>1 ->Rad s uslugama<-----------------------------------");
                    IzbornikRadSUslugama();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Rad s klijentima<---------------------------------");
                    break;  
                case 3:
                    Console.WriteLine("------------>3 ->Rad s pružateljima usluga<------------------------");
                    break;
                case 4:
                    Console.WriteLine("------------>4 ->Rad sa statusima rezervacija----------------------");
                    break; 
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

        private void IzbornikRadSUslugama()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("------------>1 ->Prikaži sve usluge<-------------------------------");
            Console.WriteLine("------------>2 ->Dodaj uslugu<-------------------------------------");
            Console.WriteLine("------------>3 ->Uredi uslugu<-------------------------------------");
            Console.WriteLine("------------>4 ->Izbriši uslugu------------------------------------");
            Console.WriteLine("------------>5 ->Povratak na glavni izbornik<----------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            OdabirStavkeIzbornikUsluge();
        }

        private void OdabirStavkeIzbornikUsluge()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*IZBORNIK - RAD S USLUGAMA*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            switch (Pomocno.UcitajInt("*.*.*.*.*.*.*.Odaberi stavku izbornika:  .*.*.*.*.*.*.*.*.*.*.--->"))
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
                    Console.WriteLine("------------>4 ->Izbriši uslugu------------------------------------");
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
            Usluge.RemoveAt(Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi uslugu za brisanje: .*.*.*.*.*.*.*.*.--->") -1);
            IzbornikRadSUslugama();
        }

        private void UrediUslugu()
        {
            PrikaziSveUsluge();
            var u = Usluge[Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi uslugu za promjenu: .*.*.*.*.*.*.*.*.--->") - 1];
            u.Sifra = Pomocno.UcitajInt(u.Sifra +  "*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru: .*.*.*.*.*.*.*.*.*.--->");
            u.Naziv = Pomocno.UcitajString(u.Naziv +"*.*.*.*.*.*.*.*.*Unesi promijenjeni naziv: .*.*.*.*.*.*.*.*.*.--->");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            IzbornikRadSUslugama();

        }

        private void DodajNovuUslugu()
        {
            Usluge.Add(new Usluga()
            {
                Sifra = Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Unesi šifru usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->"),
                Naziv = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi naziv usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->")
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
