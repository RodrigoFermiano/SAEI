using System;
using System.Collections.Generic;
using System.Text;

namespace SAIEApp.Models
{
    public class Motorista
    {
        public int IdMotorista { get; set; }
        public string Nome { get; set; }
        public int IdEndereco { get; set; }
        public int IdDocumento { get; set; }

        public DateTime DataHoraRegistro { get; set; }

        public string Situacao { get; set; }

        public int IdContato { get; set; }
    }
}
