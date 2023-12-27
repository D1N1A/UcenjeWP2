using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01Zadatci : ControllerBase
    {

        [HttpGet]
        [Route("vjezba1")]
        public string Povrsina(string Predmet, int Duzina, int Sirina)

        {
            return "Površina predmeta " + Predmet + " iznosi " + (Duzina*Sirina) + " mjernih jedinica ";
        }



        [HttpPost]
        [Route("vjezba2")]

        public float Zbroj(float[] Unos)
        {

            return ((Convert.ToInt32(Unos[0])) + Unos[Unos.Count()-1]);

        } 

    }
}