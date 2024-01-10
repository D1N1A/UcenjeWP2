

namespace UcenjeCS
{
    internal class E08ForEach
    {
        public static void Izvedi()
        {

            int[] Niz = { 1, 2, 3 };

            for (int i = 0; i < Niz.Length; i++) 
            {
                Console.WriteLine(Niz[i]);
            }

            // gornji kod je ekvivalent donjem

            foreach (int Element in Niz)
            {
                Console.WriteLine(Element);   
            }


            // sve ostale značajke petlji jednako funkcioniraju

            // tip podatka string

            string Ime = "Edunova a čšćđž";

            Console.WriteLine(Ime);



            Console.WriteLine("--------------------------");



            foreach (char c in Ime)
            {
                Console.WriteLine(c + ": " + (int)c );

            }

            Console.WriteLine("--------------------------");


            // Korisik unosi tekst a program ispisuje 
            //koje slovo je unio koliko puta
            // 
            // O
            // s
            // i
            // j
            // ...


            Console.Write("Unesi tekst: ");
            string Unos = Console.ReadLine();

            Console.WriteLine(Unos);

            int[] Slova = new int[Unos.Length];
            int index = 0;
            int ukupno;
            foreach (char c in Unos)
            {
                ukupno = 0;
                foreach (char cc in Unos)
                {
                    if (c == cc)
                    {
                        ukupno++;
                    }
                }
                Slova[index++] = ukupno;
            }

            Console.WriteLine(string.Join(",", Slova));

            char[] JedinstvenaSlova = new char[Unos.Length]; // ne treba mi toliko prostora, njaveći nedostatak nizova je taj što se na početku mora reći koliko ima elemenata
            bool postoji;
            index = 0;
            foreach (char c in Unos)
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

            Console.WriteLine(string.Join(",", JedinstvenaSlova));

            foreach (char c in JedinstvenaSlova)
            {
                Console.Write(c + " ");
                index = 0;

                foreach (char cc in Unos)
                {
                    if (c == cc)
                    {
                        Console.WriteLine(Slova[index]);
                        break;
                    }
                    index++;
                }
            }





        }
    }
}
