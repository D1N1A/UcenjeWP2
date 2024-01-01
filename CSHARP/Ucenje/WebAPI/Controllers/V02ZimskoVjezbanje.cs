using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {

        [HttpGet]
        [Route("zad1")]
        public int  Zbroj1 ()
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
        public int[] Niz ()
        {
            //Ruta vraæa niz s brojevima od 1 do brojevi
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
       
    }
}