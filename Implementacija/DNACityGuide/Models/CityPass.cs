using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class CityPass
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        public CityPass() { }

    }
}
