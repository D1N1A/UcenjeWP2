using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Polimorfizam
{
    internal abstract class Entitet
    {

        // abstraktnu klasu možemo nasljeđivat ali ne možemo instancirat
        public int Sifra { get; set; }

        // postoje i abstraktne metode
        // one služe da propišemo što će se dogoditi ali ne kako
        //Primjer knjigovodstvo: svaki dokument se mora proknjižiti ali se dokumenti na različite načine knjiže
        //                       abstraktno proknjiži ali kako će reći podklasa




        //override metoda briše unose iz nasljeđene klase

        //sučelja propisuju što bi se trebalo izvoditi ali ne kako klasa propisuje na koji način
       //klasa može nasljediti jednu klasu ali implementirat više sučelja
       // u WebAPI atributi u uglatim zagradatma []

        //enumeracije su integeri ali služe da ne pamtimo brojeve nego akciju na upalćeni broj ili tekst

        // Strukture podataka: 1. Rječnik (kao lista ima first in first out za razliku od liste koja ide redom), 2.Lista, 3.Red (peek - makne iz reda, može i s određenom klasom), 4. Stog (zadnji dođe, prvi poslužen, push i pop)
    }
}
