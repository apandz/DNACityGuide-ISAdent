using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class CityPassAtrakcije
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("CityPass")]
        public int CityPassID { get; set; }
        [ForeignKey("Atrakcija")]
        public int AtrakcijaID { get; set; }
        public CityPass CityPass { get; set; }
        public Atrakcija Atrakcija { get; set; }

        public CityPassAtrakcije()
        {
        }
    }
}
