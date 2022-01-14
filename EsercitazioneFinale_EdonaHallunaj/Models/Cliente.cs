using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale_EdonaHallunaj.Models
{
    internal class Cliente
    {
        
        public string? CodiceFiscale { get; set; }
        
        public string? Nome { get; set; }
        
        public string? Cognome { get; set; }
        
        public string? Indirizzo { get; set; }

        public ICollection<Polizza> Polizze { get; set; } = new List<Polizza>();


    }
}
