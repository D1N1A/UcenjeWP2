using UcenjeCS.E15KonzolnaAplikacija.Model;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class ObradaUsluga
    {
        public List<Usluga> Usluge{ get; }




        public ObradaUsluga()
        {
            Usluge = new List<Usluga>();
        }

        public void PrikaziIzbornik ()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*IZBORNIK - RAD S USLUGAMA*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            switch (Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.Odaberi stavku izbornika:  .*.*.*.*.*.*.*.*.*.*.--->",
                "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    Console.WriteLine("------------>1 ->Prikaži sve usluge<-------------------------------"); ;
                    PrikaziSveUsluge();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.WriteLine("------------>2 ->Dodaj uslugu<-------------------------------------");
                    DodajNovuUslugu();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.WriteLine("------------>3 ->Uredi uslugu<-------------------------------------");
                    UrediUslugu();
                    PrikaziIzbornik ();
                    break;
                case 4:
                    Console.WriteLine("------------>4 ->Izbriši uslugu<-----------------------------------");
                    IzbrisiUslugu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("------------------>Gotov rad s uslugama<---------------------------");
                    break;
            }
        }

        private void UrediUslugu()
        {
            PrikaziSveUsluge();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi uslugu za promjenu: .*.*.*.*.*.*.*.*.--->", "Nije dobar odabir", 1, Usluge.Count());
            var u = Usluge[index - 1];
            u.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru (" + u.Sifra + "): .*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            u.Naziv = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi promijenjeni naziv (" + u.Naziv + "): .*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
  

        }

        private void IzbrisiUslugu()
        {
            PrikaziSveUsluge();
            int index = Pomocno.ucitajBrojRaspon("*.*.*.*.*.*.*.*.*Odaberi uslugu za brisanje: .*.*.*.*.*.*.*.*.--->", "Nije dobar odabir", 1, Usluge.Count());
            Usluge.RemoveAt(index-1);


            
        }

        private void DodajNovuUslugu()
        {



            var u = new Usluga();
            u.Sifra = Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Unesi šifru usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos mora biti pozitivni cijeli broj");
            u.Naziv = Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi naziv usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->",
                "Unos obavezan");
            Usluge.Add(u);

        }

        public void PrikaziSveUsluge()
        {
            var i = 0;
            Usluge.ForEach(u => {
                Console.WriteLine(++i + ". " + u);
            });
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");

        }





    }
    }
