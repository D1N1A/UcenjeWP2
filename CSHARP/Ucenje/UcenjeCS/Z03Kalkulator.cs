
namespace UcenjeCS
{
    internal class Z03Kalkulator
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi ime: ");
            string Ime1 = Console.ReadLine();

            Console.WriteLine("Unesi drugo ime: ");
            string Ime2 = Console.ReadLine();

            int[] Slova = BrojSlova (Ime1, Ime2);

            Rezultat(Slova);
        }


        static int[] BrojSlova(string Ime1, string Ime2)
        {
            int[] Slova = new int[Ime1.Length + Ime2.Length];
            int index = 0;
            int ukupno;

            foreach (char c in (Ime1 + Ime2))
            {
                ukupno = 0;

                foreach (char cc in (Ime1 + Ime2))
                {
                    if (c == cc)
                    {
                        ukupno++;
                    }
                }
                Slova[index++] = ukupno;
            }

            return Slova;
        }

        static void Izracun(int[] Slova)
        {
            Console.WriteLine(string.Join(",", BrojSlova));

            char[] JedinstvenaSlova = new char[BrojSlova.Length];
            bool postoji;
            int index = 0;

            foreach (char c in (Ime1 + Ime2))
            {
                postoji = false;

                foreach (char cc in JedinstvenaSlova   )
                {
                    if (c == cc)
                    {
                        postoji = true;
                        break;
                    }
                }

                if (!postoji)
                {
                    JedinstvenaSlova[index++] = c;
                }
            }

            Console.WriteLine("Unique letters: " + new string(uniqueLetters));

            int Izracun = BrojSlova(JedinstvenaSlova, Slova);
            Console.WriteLine("Rezultat je: " + Izracun);
        }

        static int Rezultat (char[] JedinstvenaSlova, int[] BrojSlova)
        {
            int VelicinaIzracuna = 0;

            foreach (int Broj in JedinstvenaSlova)
            {
                VelicinaIzracuna += Broj;
            }

            string kalkulator = "kalkulator";
            int index = (VelicinaIzracuna % kalkulator.Length) - 1;

            return index;
        }
    }
}