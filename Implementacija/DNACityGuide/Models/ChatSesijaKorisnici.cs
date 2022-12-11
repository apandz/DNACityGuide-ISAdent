using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNACityGuide.Models
{
    public class ChatSesijaKorisnici
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        [ForeignKey("ChatSesija")]
        public int ChatSesijaID { get; set; }
        public Korisnik Korisnik { get; set; }
        public ChatSesija ChatSesija { get; set; }

        public ChatSesijaKorisnici()
        {
        }
    }
}
