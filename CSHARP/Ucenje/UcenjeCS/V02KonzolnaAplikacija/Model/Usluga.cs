using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.V02KonzolnaAplikacija.Model
{
    internal class Usluga : Entitet
    {
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
