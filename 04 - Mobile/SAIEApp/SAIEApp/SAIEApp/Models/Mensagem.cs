using System;
using System.Collections.Generic;
using System.Text;

namespace SAIEApp.Models
{
    public class Mensagem
    {
        public int IdMensagem { get; set; }
        public string TextoMensagem { get; set; }

        public DateTime DataHoraRegistro { get; set; }

        public DateTime DataHoraEnvio { get; set; }
    }
}
