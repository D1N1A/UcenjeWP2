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

            int[] Slova = BrojSlova(Ime1, Ime2);

            Izracun(Slova, Ime1, Ime2);
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

        static void Izracun(int[] Slova, string Ime1, string Ime2)
        {
            Console.WriteLine(string.Join(",", Slova));

            char[] JedinstvenaSlova = new char[Slova.Length];
            bool postoji;
            int index = 0;

            foreach (char c in (Ime1 + Ime2))
            {
                postoji = false;

                foreach (char cc in JedinstvenaSlova)
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

            Console.WriteLine("Jedinstvena slova: " + new string(JedinstvenaSlova));

            double Rezultat = KonacanRezultat(Slova.Sum(), JedinstvenaSlova.Length);
            Console.WriteLine("Rezultat je: " + Rezultat + "%");
        }

        static double KonacanRezultat(int BrojSlova, int JedinstvenaSlova)
        {
            return ((double)JedinstvenaSlova / BrojSlova) * 100;
        }
    }
}