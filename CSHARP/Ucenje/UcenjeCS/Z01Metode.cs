

namespace UcenjeCS
{
    internal class Z01Metode
    {

        //Napisati metodu koja za dva primljena deimalna broja
        //vraća cijeli dio zbroja primljenih brojeva
        // Primjer prima 2,7 i 3,7 a vraća 6

        public static int CijeliBroj(float Prvi, float Drugi)
        {
            return CijeliBroj((double)Prvi,(double)Drugi);    

        }

        // method overloading
        //potpis metode : naziv + lista parametara

        public static int CijeliBroj (double Prvi, double Drugi) 
        {
            return (int)(Prvi + Drugi);

        }
    }


}
