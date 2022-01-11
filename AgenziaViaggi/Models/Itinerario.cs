using System.ComponentModel.DataAnnotations;

namespace AgenziaViaggi.Models
{
    public class Itinerario
    {
        [Key]
        public int ItinerarioID { get; set; }
        public string Descrizione { get; set; }
        public int Prezzo { get; set; } 
        public int Durata { get; set; }
        public ICollection<Gita> Gite { get; set; } = new List<Gita>();


    }
}