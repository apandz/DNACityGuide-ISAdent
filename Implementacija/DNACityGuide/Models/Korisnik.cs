using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class Korisnik
    {
        [Key]
        public int ID { get; set; }
        public DateTime DatumPrijave { get; set; }
        public VrstaTurista VrstaTurista { get; set; }
        public KategorijaTurista KategorijaTurista { get; set; }
        public string NazivAgencije { get; set; }
        [ForeignKey("AspNetUsers")]
        public int AspNetUsers { get; set; }

        public Korisnik()
        {
        }
    }
}
