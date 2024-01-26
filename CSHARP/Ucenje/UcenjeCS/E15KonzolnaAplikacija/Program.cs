using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Program
    {

     public Program ()
        {
            PozdravnaPoruka();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("Izbornik");
            Console.WriteLine("1. Rad sa smjerovima");
            Console.WriteLine("2. Rad s predavačima");
            Console.WriteLine("3. Rad s polazniucima");
            Console.WriteLine("4. Rad s grupama");
            Console.WriteLine("5. Izlaz iz programa");
            var izbor = Pomocno.UcitajString("Unesi svoj izbor: ");
            Console.WriteLine("Unesite vaš izbor: ");
            //treba čitati string, int, date, bool za to služi klasa Pomoćno
        
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("* EDUNOVA KONZONLNA APLIKACIJA V1 *");
            Console.WriteLine("***********************************");
        }
    }
}
