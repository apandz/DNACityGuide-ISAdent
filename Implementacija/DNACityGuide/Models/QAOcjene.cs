using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class QAOcjene
    {
        [Key]
        public int ID { get; set; }
        public double Ocjena { get; set; }
        [ForeignKey("QASesija")]
        public int QASesijaID { get; set; }
        public QASesija QASesija { get; set; }
        public QAOcjene()
        {
        }
    }
}