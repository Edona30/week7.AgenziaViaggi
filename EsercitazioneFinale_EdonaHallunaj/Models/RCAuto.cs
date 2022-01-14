using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale_EdonaHallunaj.Models
{
    internal class RCAuto : Polizza
    {
     
        [MaxLength(5)]
        public string? Targa { get; set; }
        public int Cilindrata { get; set; }
    }
}
