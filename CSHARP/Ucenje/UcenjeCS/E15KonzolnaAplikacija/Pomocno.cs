using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    //engl. Utility ili Util
    internal class Pomocno
    {
        //kod statične metode klasa ne čuva stanje
        //inače klasa ima metode i čuva stanja

        public static string UcitajString(string poruka) {
            while (true)
            {
                Console.WriteLine(poruka);
                string s = Console.ReadLine();
                if(s.Trim().Length == 0)
                {
                    Console.Write("Obavezan unos");
                    continue;
                }
                return s;
            }
        }
    }
}
