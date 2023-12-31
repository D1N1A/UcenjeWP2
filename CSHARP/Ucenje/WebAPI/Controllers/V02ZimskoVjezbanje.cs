using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {

        [HttpGet]
        [Route("Zadatak")]
        public int  Zbroj ()
        { 

            int[] niz = new int[100];


            int suma = 0;
            for (int i = 1; i<= niz.Length; i++)
            {
                suma += i;
            }
            return suma;
        }



    }
}