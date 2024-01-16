using System.Xml;

namespace UcenjeCS
{
    internal class E11Rekurzija
    {
        public static void Izvedi()
        {
            // rekurzija je kada metoda zove samu sebe UZ ZVJET PREKIDA REKURZIJE
            // Izvedi (); // Dobijemo stackoverflow iznimku

            Console.WriteLine(Zbroj(100));

        }

        private static int Zbroj(int v)
        {
            // uvjet prekida rekurzije 

            if (v == 1) 
            {
                return 1;
            }

            return v + Zbroj(v-1);
        }
    }
}
