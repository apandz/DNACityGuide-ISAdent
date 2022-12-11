using System.ComponentModel.DataAnnotations;

namespace DNACityGuide.Models
{
    public class ChatSesija
    {
        [Key]
        public int ID { get; set; }
        public string NazivGrupe { get; set; }
        public ChatSesija () { }
    }
}
