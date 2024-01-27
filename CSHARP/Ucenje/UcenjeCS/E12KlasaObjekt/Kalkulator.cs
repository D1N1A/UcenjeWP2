using System;
using System.Collections.Generic;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Kalkulator
    {
        private List<int> rezultat;
        private int indeksRezultata = 0;

        public string PrvoIme { get; set; }
        public string DrugoIme { get; set; }

        public Kalkulator() { // prazan konstruktor
                              //ovdje se dolazi kada se izvodi ključna riječ new
                              }
            public Kalkulator(string prvoIme, string drugoIme)
        {
            this.PrvoIme = prvoIme;
            this.DrugoIme = drugoIme;
        }

        public string Rezultat()
        {
            return Izracunaj(SlovaUNiz(PrvoIme + DrugoIme)) + " %";
        }

        private int Izracunaj(List<int> brojevi)
        {
            if (brojevi.Count < 3)
            {
                return ZavrsniNiz(brojevi);
            }

            List<int> zbrojevi = new List<int>(brojevi.Count / 2 + brojevi.Count % 2);
            int indeks = 0;

            for (int i = 0; i < (brojevi.Count + 1) / 2; i++)
            {
                int zbroj = brojevi[i] + brojevi[brojevi.Count - 1 - i];

                if (i >= (brojevi.Count - 1) / 2 && brojevi.Count % 2 != 0)
                {
                    zbrojevi.Add(brojevi[i]);
                }
                else
                {
                    zbrojevi.Add(zbroj);
                }
            }

            var pretvorenoUDvaznamenkasti = PretvoriListu(zbrojevi);

            return Izracunaj(PretvoriListu(zbrojevi));
        }

        private List<int> PretvoriListu(List<int> brojevi)
        {
            List<int> rezultat = new List<int>(brojevi.Count * 2);
            int indeks = 0;

            foreach (int num in brojevi)
            {
                if (num < 10)
                {
                    rezultat.Add(num);
                }
                else
                {
                    int desetice = num / 10;
                    int jedinice = num % 10;

                    rezultat.Add(desetice);
                    rezultat.Add(jedinice);
                }
            }


            return rezultat;
        }

        private int ZavrsniNiz(List<int> niz)
        {
            string stringNiz = string.Join("", niz);

            int rezultat = int.Parse(stringNiz);

 

            return rezultat;
        }

        private List<int> SlovaUNiz(string imena)
        {
            int indeks = 0;
            List<int> brojevi = new List<int>(imena.Length);

            foreach (char c in imena)
            {
                int ukupno = 0;

                foreach (char cc in imena)
                {
                    if (c == cc)
                    {
                        ukupno++;
                    }
                }

                brojevi.Add(ukupno);
            }

            return brojevi;
        }
    }
}