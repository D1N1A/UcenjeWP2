
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.V02KonzolnaAplikacija.Model
{
    internal class Osoba : Entitet
    {
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public Usluga Usluga { get; set; }
    }
}
