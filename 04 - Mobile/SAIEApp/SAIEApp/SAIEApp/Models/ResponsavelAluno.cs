using System;
using System.Collections.Generic;
using System.Text;

namespace SAIEApp.Models
{
    public class ResponsavelAluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int IdEndereco { get; set; }

        public int IdContato { get; set; }
        
        public int IdDocumento { get; set; }
    }
}
