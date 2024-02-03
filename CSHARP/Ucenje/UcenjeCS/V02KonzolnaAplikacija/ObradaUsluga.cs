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
            switch (Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.Odaberi stavku izbornika:  .*.*.*.*.*.*.*.*.*.*.--->",))
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
            var u = Usluge[Pomocno.ucitajCijeliBroj("*.*.*.*.*.*.*.*.*Odaberi uslugu za promjenu: .*.*.*.*.*.*.*.*.--->",) - 1];
            u.Sifra = Pomocno.ucitajCijeliBroj(u.Sifra +  "*.*.*.*.*.*.*.*.*Unesi promijenjenu šifru: .*.*.*.*.*.*.*.*.*.--->",);
            u.Naziv = Pomocno.ucitajCijeliBroj(u.Naziv +"*.*.*.*.*.*.*.*.*Unesi promijenjeni naziv: .*.*.*.*.*.*.*.*.*.--->",);
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            PrikaziIzbornik();

        }

        private void IzbrisiUslugu()
        {
            PrikaziSveUsluge();
            Usluge.RemoveAt(V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Odaberi uslugu za brisanje: .*.*.*.*.*.*.*.*.--->") -1);
            PrikaziIzbornik();
        }

        private void DodajNovuUslugu()
        {
            Usluge.Add(new Usluga()
            {
                Sifra = V02KonzolnaAplikacija.Pomocno.UcitajInt("*.*.*.*.*.*.*.*.*Unesi šifru usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->"),
                Naziv = V02KonzolnaAplikacija.Pomocno.UcitajString("*.*.*.*.*.*.*.*.*Unesi naziv usluge:  *.*.*.*.*.*.*.*.*.*.*.*.--->")
            });
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
