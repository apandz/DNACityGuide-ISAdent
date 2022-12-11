using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class ChatSesijaPoruke
    {
        [Key]
        public int ID { get; set; }
        public string Poruka { get; set; }
        [ForeignKey("ChatSesija")]
        public int ChatSesijaID { get; set; }
        public ChatSesija ChatSesija { get; set; }
        public ChatSesijaPoruke()
        {
        }
    }
}