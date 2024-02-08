using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class Izbornik
    {
        public ObradaUsluga ObradaUsluga { get; }
        public ObradaKlijent ObradaKlijent { get; }

        public ObradaPruzateljUsluge PruzateljUsluge { get; }

        public ObradaStatusRezervacije StatusRezervacije { get; }


    


        public Izbornik()
        {
            Pomocno.dev = true;
            ObradaUsluga = new ObradaUsluga();
            ObradaKlijent = new ObradaKlijent();
            ObradaPruzateljUsluge ();
            ObradaStatusRezervacije();
            PozdravnaPoruka();
            PrikaziIzbornik();

        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*USLUGE ZA KUĆNE LJUBIMCE APLIKACIJA V1 *.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
        }

        private void PrikaziIzbornik()
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
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*Unesi izbor: *.*.*.*.*.*.*.*.*.*.*.*.*.*.--->");
            Console.WriteLine("------------>1 ->Rad s uslugama<-----------------------------------");
            Console.WriteLine("------------>2 ->Rad s klijentima<---------------------------------");
            Console.WriteLine("------------>3 ->Rad s pružateljima usluga<------------------------");
            Console.WriteLine("------------>4 ->Rad sa statusima rezervacija----------------------");


            switch (Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*.*.*Unesi izbor: *.*.*.*.*.*.*.*.*.*.*.*.*.*.--->",
              "Odabir mora biti 1 - 4.", 1, 4))
            {
                case 1:
                    ObradaUsluga.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaKlijent.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaPruzateljUsluge.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObradaStatusRezervacije.PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("------------>5 ->Izlaz iz programa<--------------------------------");
                    Console.WriteLine("-------------------------------------------------------------------");
                    break;


            }

        }

    }

}




        