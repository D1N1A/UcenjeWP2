using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E07")]
    public class E07Metode : ControllerBase
    {

        // Napišite metodu koja za dva primljena cijela broja vraæa njihov zbroj, neka ova metoda Zad1 vrati rezultat napisane metode zadatka
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {
            return Zbroj(PrviBroj, DrugiBroj);
        }

        int Zbroj(int PrviBroj, int DrugiBroj)
        {
            return PrviBroj + DrugiBroj;
        }



        // Kreirati rutu zad2 koja prima 4 cijela broja i vraæa razliku prvi+drugi i treæi+èetvrti, koristite kreiranu metodu za zbroj cijelog broja
        [HttpGet]
        [Route("zad2")]
        public int Zad2(int PrviBroj, int DrugiBroj, int TreciBroj, int CetvrtiBroj)
        {

            return Zbroj(PrviBroj, DrugiBroj) - Zbroj(TreciBroj, CetvrtiBroj);
        }



        // Kreirati rutu zad3 koja prima ime grada i slovo. Ruta vraæa broj pojavljivanja primljenog slova u primljenom imenu grada. Koristiti metode
        [HttpGet]
        [Route("zad3")]
        public int Zad3(string Grad, string Slovo)
        {
            return GradSlova(Grad, Slovo);
        }

        private int GradSlova(string Grad, string Slovo)
        {
            int Ukupno = 0;
            foreach (char c in Grad)
            {
                if (c == Slovo[0])
                {
                    Ukupno++;
                }
            }

            return Ukupno;
        }

    }
}