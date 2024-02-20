using System.ComponentModel.DataAnnotations;

namespace UslugeZaKucneLjubimce.Models
{
    /// <summary>
    /// Ovo mi je POCO koji je mapiran na bazu
    /// </summary>
    public class StatusRezervacije:Entitet
    {
        /// <summary>
        /// Naziv u bazi
        /// </summary>
        [Required(ErrorMessage ="Naziv statusa obavezan")]
        public Boolean Naziv { get; set; }
        [Required(ErrorMessage = "Boja statusa obavezna")]
        public string? Boja { get; set; }
    }
}
