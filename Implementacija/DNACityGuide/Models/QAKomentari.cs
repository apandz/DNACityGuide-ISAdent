using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class QAKomentari
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Komentar")]
        public int KomentarID { get; set; }
        [ForeignKey("QASesija")]
        public int QASesijaID { get; set; }
        public Komentar Komentar { get; set; }
        public QASesija QASesija { get; set; }
        

        public QAKomentari()
        {
        }
    }
}
