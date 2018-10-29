using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Dados
{
    public interface IDocumentoDAL
    {
        List<Documento> Get();
        Documento Get(int id);
        bool Post(Documento obj);
        bool Put(int id, Documento obj);
        bool Delete(int id);
    }
}
