using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class MapaAtrakcije
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Mapa")]
        public int MapaID { get; set; }
        [ForeignKey("Atrakcija")]
        public int AtrakcijaID { get; set; }
        public Mapa Mapa { get; set; }
        public Atrakcija Atrakcija { get; set; }

        public MapaAtrakcije()
        {
        }
    }
}
