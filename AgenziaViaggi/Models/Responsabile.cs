using System.ComponentModel.DataAnnotations;

namespace AgenziaViaggi.Models
{
    public class Responsabile
    {
        [Key]
        public int RespondabileID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumerodiTelefono { get; set; }
        public ICollection<Gita> Gite { get; set; } = new List<Gita>();

    }
}