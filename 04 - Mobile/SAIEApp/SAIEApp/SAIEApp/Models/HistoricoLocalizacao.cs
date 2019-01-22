using System;
using System.Collections.Generic;
using System.Text;

namespace SAIEApp.Models
{
    public class HistoricoLocalizacao
    {
        public int IdHistoricoLocalizacao { get; set; }
        public int IdEntidadePessoa { get; set; }
        public DateTime DataHoraRegistro { get; set; }
        public string Longitude { get; set; }
        public string Altitude { get; set; }
        public string Tempo { get; set; }
        public string Provider { get; set; }
        public string Velocidade { get; set; }
        public string PrecisaoPonto { get; set; }


    }
}
