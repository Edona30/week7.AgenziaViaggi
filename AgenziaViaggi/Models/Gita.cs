using System.ComponentModel.DataAnnotations;

namespace AgenziaViaggi.Models
{
    public class Gita
    {
        [Key]
        public int GitaID { get; set; }
        public DateTime Partenza { get; set; }
        public int ResponsabileID { get; set; }
        public Responsabile Respondabile { get; set; }
        public int ItinerarioID { get; set; }
        public Itinerario Itinerario { get; set; }

        //Relazione molti a molti con Patecipanti
        public ICollection<Partecipante> Partecipanti { get; set; } = new List<Partecipante>();


    }
}