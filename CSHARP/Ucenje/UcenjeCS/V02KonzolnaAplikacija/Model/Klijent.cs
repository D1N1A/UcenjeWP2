using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.V02KonzolnaAplikacija.Model
{
    internal class Klijent : Osoba
    {
        public PruzateljUsluge PruzateljUsluge { get; set; }
        public string ImeKlijenta { get; set; }
        public string Pasmina { get; set; }
        public string Napomena { get; set; }
        public string ImeVlasnika { get; set; }
        public string PrezimeVlasnika { get; set; }
        public StatusRezervacije StatusRezervacije { get; set; }
    }
}
