using System;

namespace UcenjeCS
{
    internal class Z02Vjezba
    {
        public static void Izvedi()
        {
            int pb = UcitajBroj("Unesi prvi broj: ");
            int db = UcitajBroj("Daj mi i drugi: ");

            int suma = Suma(pb, db);
            int najmanji = NajmanjiBroj(pb, db);
            int najveci = NajveciBroj(pb, db);
            double prosjek = Prosjek(pb, db);

            Console.WriteLine($"Zbroj: {suma}");
            Console.WriteLine($"Najmanji: {najmanji}");
            Console.WriteLine($"Najveći: {najveci}");
            Console.WriteLine($"Prosjek: {prosjek}");
        }

        private static double Prosjek(int pb, int db)
        {
            int suma = 0;
            int brojac = 0;

            for (int i = Math.Min(pb, db) + 1; i < Math.Max(pb, db); i++)
            {
                suma += i;
                brojac++;
            }

            if (brojac == 0)
            {
                return 0;
            }

            return (double)suma / brojac;
        }

        private static int NajveciBroj(int pb, int db)
        {
            return Math.Max(pb, db);
        }

        private static int NajmanjiBroj(int pb, int db)
        {
            return Math.Min(pb, db);
        }

        private static int Suma(int pb, int db)
        {
            int suma = 0;

            for (int i = Math.Min(pb, db) + 1; i < Math.Max(pb, db); i++)
            {
                suma += i;
            }

            return suma;
        }

        private static int UcitajBroj(string v)
        {
            for (; ; )
            {
                Console.Write(v);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nisi unio broj");
                }
            }
        }
    }
}