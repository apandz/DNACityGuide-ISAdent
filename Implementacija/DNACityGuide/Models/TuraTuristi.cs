using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class TuraTuristi
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Tura")]
        public int TuraID { get; set; }
        [ForeignKey("Korisnik")]
        public int TuristID { get; set; }
        public Tura Tura { get; set; }
        public Korisnik Turist { get; set; }

        public TuraTuristi()
        {
        }
    }
}
