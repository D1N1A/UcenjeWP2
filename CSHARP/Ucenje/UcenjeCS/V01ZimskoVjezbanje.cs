
namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {

            // Zadatak 1

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("********************");

            // Zadatak 2

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********************");

            // Zadatak 3
            for (int i = 1; i < 101; i++)
            {
                if (i%7 !=0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("********************");

            // Zadatak 4



            Console.WriteLine("Program broji pokušaje dok se ne upiše broj 100");
            int broj;
            for (int pokusaj = 1; ;)
            {
                Console.Write("Unesite broj veći od 100 ");
                broj = int.Parse(Console.ReadLine());
                if (broj < 101)
                {
                    pokusaj++;
                    Console.WriteLine("Unjeli ste broj koji je manji od 100");
                    continue;
                }
                else
                {
                    Console.WriteLine("Trebalo Vam je " + pokusaj + "da biste unjeli broj " + broj);
                    broj = 1;
                }
                continue;
            }


        }
    }
}
