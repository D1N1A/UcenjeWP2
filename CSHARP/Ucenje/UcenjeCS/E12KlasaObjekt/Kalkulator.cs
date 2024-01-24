
namespace UcenjeCS.E12KlasaObjekt
{
    internal class Kalkulator
    {
        public string PrvoIme { get; set; }

        public string DrugoIme { get; set; }

        // Ovo je kontruktor - 5. vrsta metoda
        public Kalkulator() { 
        // ovdje se dolazi kada se izvodi ključna riječ new
        }

        public Kalkulator(string prvoIme, string drugoIme) {
        
            this.PrvoIme = prvoIme;
            drugoIme = drugoIme;
        }

        public string Rezultat()
        { 
            return Izracunaj (SlovaUniz(PrvoIme+DrugoIme)) + " %";
        }

        private int Izracunaj (int[] brojevi)
        {

            //ovo je sad fiksno, tu dolazi rekurzivni algoritam
            return 67;
        }

        private int[] SlovaUniz (string Imena)
        {
            // fiksno 

            return new int[2];
        }
    }
}
