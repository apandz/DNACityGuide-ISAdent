using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class QARecenzije
    {
        [Key]
        public int ID { get; set; }
        public double Recenzija { get; set; }
        [ForeignKey("QASesija")]
        public int QASesijaID { get; set; }
        public QASesija QASesija { get; set; }
        public QARecenzije()
        {
        }
    }
}
