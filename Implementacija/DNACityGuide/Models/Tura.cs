using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class Tura
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        [ForeignKey("Korisnik")]
        public int VodicID { get; set; }
        public Korisnik Vodic { get; set; }
        public string Opis { get; set; }
        public int Kapacitet { get; set; }

        public Tura()
        {
        }
    }
}
