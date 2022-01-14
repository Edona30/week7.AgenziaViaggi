using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale_EdonaHallunaj.Models
{
    internal class Furto : Polizza
    {
        
        public int PercentualeCoperta { get; set; }
    }
}
