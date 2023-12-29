
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

            

        }   
    }
}
