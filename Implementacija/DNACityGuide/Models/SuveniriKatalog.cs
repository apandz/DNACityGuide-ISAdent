using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class SuveniriKatalog
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Suvenir")]
        public int SuvenirID { get; set; }
        [ForeignKey("KatalogSuvenira")]
        public int KatalogSuveniraID { get; set; }
        public Suvenir Suvenir { get; set; }
        public KatalogSuvenira KatalogSuvenira { get; set; }

        public SuveniriKatalog()
        {
        }
    }
}
