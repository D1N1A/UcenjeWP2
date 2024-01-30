using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class Pomocno
    {
        public static int UcitajInt(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    int unos = int.Parse(Console.ReadLine());

                    if (unos >= 0)
                    {
                        return unos;
                    }
                    else
                    {
                        Console.WriteLine("Unesite pozitivan broj.");
                    }
                }
                catch
                {
                    Console.WriteLine("Neispravan unos. Unesite pozitivan broj.");
                }
            }

        }


        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }

        public static bool UcitajBool(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    return bool.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite 'istina' ili 'neistina'.");
                }
            }
        }

    }
}
