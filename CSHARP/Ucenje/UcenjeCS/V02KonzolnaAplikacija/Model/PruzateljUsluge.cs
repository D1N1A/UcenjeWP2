using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.V02KonzolnaAplikacija.Model
{
    internal class PruzateljUsluge : Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Fotografija { get; set; }
        public  string Adresa { get; set; }

        public List <Usluga> Usluge { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime ;
        }

    }
}
