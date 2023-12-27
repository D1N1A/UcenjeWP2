using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class E01Vjezba1 : ControllerBase
    {

        [HttpGet]
        [Route("vjezba1")]
        public string Povrsina (string Predmet,int Duzina, int Sirina)

        {
            return "Površina predmeta " + Predmet + " iznosi " + (Duzina*Sirina) + " mjernih jedinica ";
        }

    }
}