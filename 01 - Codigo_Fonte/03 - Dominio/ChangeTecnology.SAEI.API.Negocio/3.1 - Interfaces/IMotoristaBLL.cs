using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public interface IMotoristaBLL
    {
        List<Motorista> Get();
        Motorista Get(int id);
        bool Post(Motorista obj);
        bool Put(int id, Motorista obj);
        bool Delete(int id);
    }
}
