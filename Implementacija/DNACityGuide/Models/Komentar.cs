using System.ComponentModel.DataAnnotations;

namespace DNACityGuide.Models
{
    public class Komentar
    {
        [Key]
        public int ID { get; set; }
        public string Tekst { get; set; }
        public int Prijavljen { get; set; }

        public Komentar()
        {
        }
    }
}
