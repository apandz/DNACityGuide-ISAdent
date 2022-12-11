using System.ComponentModel.DataAnnotations;

namespace DNACityGuide.Models
{
    public class Atrakcija
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public Atrakcija () { }
    }
}
