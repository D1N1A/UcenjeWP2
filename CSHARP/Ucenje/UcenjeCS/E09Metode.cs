

using Microsoft.Win32.SafeHandles;

namespace UcenjeCS
{
    internal class E09Metode
    {
        private static bool i;

        public static void Izvedi ()
        {

            // do OOP-a sve metode će biti static u ovom projektu Ucenje CS
            //POZIV METODE

            Tip1();
            Tip2(3,23);
            // Ključna riječ var uzima tip podatka s desne strane 
            var Ime = ImeRacunala();  //Tip 3
            Console.WriteLine(Ime);
            //bolje ovako:
            Console.WriteLine(ImeRacunala());

            Console.WriteLine(JePrimBroj(7) ? "PRIM" : "NIJE");

            //Zadatak: Ispiši sve prim brojeve između dva broja
            SviPrimBrojevi(27, 99);
        }

        private static void SviPrimBrojevi(int Od, int Do)
        {
            for (int i = Od; i <= Do; i++);
            {
                if (PrimBroj(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool PrimBroj(bool i)
        {
            throw new NotImplementedException();
        }

        //1. vrsta: tipa void, ne prima vrijednost ali prima praznu listu parametara

        static void Tip1()
        {
            //kada ne piše public-čitljiva i u drugim klasama ili private-samo u toj klasi čitljiva onda je internal

            //void označava - prazno - ova metoda ništa ne vraća dok int vraća niz

            // u zagradi iza imena je lista parametara koje prima ako nema ništa onda je null


            Console.WriteLine("Hello tip 1");
        }

        //Prvo se pokreće Program.CS, zatim Izvedi, pa Tip 1

        //2. vrsta; tipa void, prima parametre

        static void Tip2(int Od, int Do)
        {
        //naziv Od i Do vrijedi samo unutar te metode
        //ispišite sve parne brojeme između dva primljena parametra

        for (int i = Od; i <= Do; i++) 
            {
                if (i%2 !=0) 
                {
                    continue;
                }
                Console.WriteLine(i);
            }
         // kada je naziv metode blijedo-sive boje tada nikada nije korištena

        }

        //3. vrsta: je određenog tipa koji vraća pozivatelju, ne prima parametre

        static string ImeRacunala ()
        {
            return System.Net.Dns.GetHostName();
        }

        //4. vrsta -  najkorisnija - određenog tipa koji vraća pozivatelju i prima parametre

        static bool JePrimBroj (int Broj)
        {


            for (int i = 2; i < Broj; i ++)
            {
                if (Broj % i == 0)
                {
                    return false; 
                }
            }


            return true;
        }





    
    }
}
