using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.V02KonzolnaAplikacija
{
    internal class ObradaStatusRezervacije
    {
        public List<StatusRezervacije> StatusRezervacija { get; }

        private Izbornik Izbornik;

        public ObradaStatusRezervacije(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public ObradaStatusRezervacije()
        {
            StatusRezervacija = new List<StatusRezervacije>();
        }
    }
}
