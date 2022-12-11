using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class TureZaRezervaciju
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Tura")]
        public int TuraID { get; set; }
        [ForeignKey("RezervacijaTura")]
        public int RezervacijaTuraID { get; set; }
        public Tura Tura { get; set; }
        public RezervacijaTura RezervacijaTura { get; set; }

        public TureZaRezervaciju()
        {
        }
    }
}
