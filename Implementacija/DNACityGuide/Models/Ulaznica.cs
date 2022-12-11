using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class Ulaznica
    {
        [Key]
        public int ID { get; set; }
        public string NazivAtrakcije { get; set; }
        public double Cijena { get; set; }
        public double Popust { get; set; }
        public int DostupnaKolicina { get; set; }
        [ForeignKey("Korisnik")]
        public int KupacID { get; set; }
        public Korisnik Kupac { get; set; }

        public Ulaznica()
        {
        }
    }
}
