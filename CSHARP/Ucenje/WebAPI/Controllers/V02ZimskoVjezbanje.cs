using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {

        [HttpGet]
        [Route("zad1")]
        public int Zbroj1()
        {

            int[] niz = new int[100];


            int suma = 0;
            for (int i = 1; i<= niz.Length; i++)
            {
                suma += i;
            }
            return suma;
        }


        [HttpGet]
        [Route("zad2")]
        public int[] Niz1()
        {

            int[] niz = new int[57];
            for (int i = 0; i < 57; i++)
            {
                if (i%2 == 0)
                {
                    continue;
                }
                niz[i] = i+1;
            }

            return niz;
        }

        [HttpGet]
        [Route("zad3")]
        public int Zbroj2()
        {

            int[] niz = new int[18];


            int suma = 0;
            for (int i = 1; i<= niz.Length; i++)
            {
                if (i%2 != 0)
                {
                    continue;
                }

                suma += i;
            }
            return suma;
        }

        [HttpGet]
        [Route("zad4")]
        public int Zbroj2(int broj)
        {

            int suma = 0;
            for (int i = 1; i<= broj; i++)
            {
                suma += i;
            }
            return suma;

        }

        [HttpGet]
        [Route("zad5")]
        public int[] Niz2(int Min, int Max)
        {

            int[] niz = new int[Max];
            for (int i = Min; i < Max; i++)
            {
                if (i%2 != 0)
                {

                    continue;
                }
                niz[i] = i;
            }

            return niz;
        }

        [HttpGet]
        [Route("zad6")]
        public int[] Niz3(int Min, int Max)
        {

            int[] niz = new int[Max];
            for (int i = Min; i < Max; i++)
            {
                if (i%2 == 0)
                {

                    continue;
                }
                niz[i] = i;
            }

            return niz;
        }


        [HttpGet]
        [Route("zad7")]
        public int Zbroj3(int Min, int Max)
        {
            int[] niz = new int[Max];
            int suma = 0;
            for (int i = Min; i < Max; i++)
            {

                suma += i; ;
            }

            return suma-Min;
        }

        [HttpGet]
        [Route("zad8")]
        public int Zbroj4(int Min, int Max)
        {
            int[] niz = new int[Max];
            int suma = 0;
            for (int i = Min; i < Max; i++)
            {

                if (i%3 != 0)
                {
                    continue;
                }

                suma += i; ;
            }

            return suma-Min;
        }

        [HttpGet]
        [Route("zad9")]
        public int Zbroj5 (int Min, int Max)
        {
            int[] niz = new int[Max];
            int suma = 0;
            for (int i = Min+1; i < Max; i++)
            {

                if ((i%3 != 0) & (i%5 != 0))
                {
                    continue;
                }

                suma += i; ;
            }

            return suma;
        }

        [HttpGet]
        [Route("zad10")]
        public int [,] Niz4 (int Prvi, int Drugi)
        {
            int[] niz = new int[Prvi,Drugi];
            
            for (int i = 1; i < Prvi; i++)
            {
                for (int j = 1; j < Drugi; j++)
                

                return i*j; ;
            }

            return niz;
        }
    }
}