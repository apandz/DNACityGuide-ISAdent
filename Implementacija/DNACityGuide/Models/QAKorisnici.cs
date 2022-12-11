using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class QAKorisnici
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        [ForeignKey("QASesija")]
        public int QASesijaID { get; set; }
        public Korisnik Korisnik { get; set; }
        public QASesija QASesija { get; set; }

        public QAKorisnici()
        {
        }
    }
}
