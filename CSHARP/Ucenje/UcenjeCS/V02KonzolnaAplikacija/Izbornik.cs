using System;
using UcenjeCS.E15KonzolnaAplikacija;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class Izbornik
    {
        public ObradaUsluga ObradaUsluga { get; }
        public ObradaKlijent ObradaKlijent { get; }
        public ObradaPruzateljUsluge ObradaPruzateljUsluge { get; }
        public ObradaStatusRezervacije ObradaStatusRezervacije { get; }

        public Izbornik()
        {
            Pomocno.dev = true;
            ObradaUsluga = new ObradaUsluga();
            ObradaKlijent = new ObradaKlijent();
            ObradaPruzateljUsluge = new ObradaPruzateljUsluge();
            ObradaStatusRezervacije = new ObradaStatusRezervacije();
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
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*..*.*.*.*.*.*.*.*.*.*.*.*IZBORNIK.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
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
            int izbor;
            do
            {
                Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*Unesi izbor: *.*.*.*.*.*.*.*.*.*.*.*.*.*.--->");
                izbor = Pomocno.ucitajBrojRaspon("Odabir mora biti 1 - 5.","Pogrešan odabir", 1, 5);

                switch (izbor)
                {
                    case 1:
                        ObradaUsluga.PrikaziIzbornik();
                        break;
                    case 2:
                        ObradaKlijent.PrikaziIzbornik();
                        break;
                    case 3:
                        ObradaPruzateljUsluge.PrikaziIzbornik();
                        break;
                    case 4:
                        ObradaStatusRezervacije.PrikaziIzbornik();
                        break;
                    case 5:
                        Console.WriteLine("Izlaz iz programa.");
                        break;
                    default:
                        Console.WriteLine("Neispravan unos. Unesite ponovno.");
                        break;
                }
            } while (izbor != 5);
        }
    }
}
