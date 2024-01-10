﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07DoWhile
    {
        public static void Izvedi()
        {

            // da li se u for(od kuda do kuda) i while(sve dok) mora ući? NE
            // Ako uvjet na početku nije zadovoljen ne ulazi se

            // do while osigurava minimalno jedno izvođenje
            // uvjet je na kraju petlje

            //beskonačna petlja

            do

            {
                Console.WriteLine("Edunova");

            } while (false);

            // continue, break i ugnježđivanje isto kao kod for i while

            // Prekidanje vanjske petlje

            for (; ; )
            {
                while (true)
                {
                    do
                    {
                        // break; //1
                        //Kako prekinuti vanjski for
                        goto nakonfor;
                    } while (true);

                    //ovdje se nastavlja 2
                }

                nakonfor: // ovo je labela
                Console.WriteLine("odradio");
            }
        }
    }
}
