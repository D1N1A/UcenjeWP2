using UcenjeCS.E15KonzolnaAplikacija.Model;
using UcenjeCS.V02KonzolnaAplikacija.Model;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class ObradaUsluga
    {
        public List<Usluga> Usluge{ get; }

        private Izbornik Izbornik;

        public ObradaUsluga(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public ObradaUsluga()
        {
            Usluge = new List<Usluga>();
        }


    }
    }
