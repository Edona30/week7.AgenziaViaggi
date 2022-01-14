using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale_EdonaHallunaj.Models
{
    internal class Polizza
    {
        
        public int Numero { get; set; }
        public DateTime DataStipula { get; set; }
        public float? ImportoAssicurato { get; set; }
        public float? RataMensile { get; set; }
        public string? CodiceFiscale { get; set; }
        public Cliente Cliente { get; set; }


    }
}
