using System.ComponentModel.DataAnnotations;

namespace DNACityGuide.Models
{
    public class Suvenir
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public string Opis { get; set; }
        public string MjestoKupovine { get; set; }
        public int NaStanju { get; set; }

        public Suvenir()
        {
        }
    }
}
