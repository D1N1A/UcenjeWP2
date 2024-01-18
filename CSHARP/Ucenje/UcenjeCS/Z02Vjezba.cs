
using System.Diagnostics.Metrics;

namespace UcenjeCS
{
    internal class Z02Vjezba

    {
        // Program učitava brojeve sve dok se ne unese broj -1
        //Program ispisuje:
        //1.Zbroj unesenih brojeva
        //2.Najmanji broj
        //3.Najveći broj
        //4.Prosjek svih unesenih brojeva

        //KORISTITI METODE I OBRADU IZNIMKI

        public static void Izvedi()
        {
            int pb = UcitajBroj("Unesi prvi broj: ");
            int db = UcitajBroj("Daj mi i drugi: ");


            Suma(pb, db);
            NajmanjiBroj(pb, db);
            NajveciBroj(pb, db);
            Prosjek(pb, db);
        }

        private static void Prosjek(int pb, int db)
        {
            int sum = 0;
            int brojac = 0;

            for (int i = NajmanjiBroj + 1; i < NajveciBroj; i++)
            {
                sum += i;
                brojac++;
            }

          
            if (brojac == 0)
            {
                return 0;
            }

            return (double)sum / brojac;
        }
    }

        private static void NajveciBroj(int pb, int db)
        {
         
                if (pb>=db)
                {
                    Console.WriteLine(pb);
                }
                else
                {
                    Console.WriteLine(db);
                }
            
            }

        private static void NajmanjiBroj(int pb, int db)
        {
            if (pb<=db)
            {
                Console.WriteLine(pb);
            }
            else
            {
                Console.WriteLine(db);
            }
        }

        private static void Suma(int pb, int db)
        {
            int sum = 0;


            for (int i = NajmanjiBroj + 1; i < NajveciBroj; i++)
            {
                sum += i;
            }

            return sum;
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
