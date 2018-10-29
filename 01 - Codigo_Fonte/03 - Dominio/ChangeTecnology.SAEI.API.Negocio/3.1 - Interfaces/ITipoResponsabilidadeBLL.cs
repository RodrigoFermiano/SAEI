using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public interface ITipoResponsabilidadeBLL
    {
        List<TipoResponsabilidade> Get();
        TipoResponsabilidade Get(int id);
        bool Post(TipoResponsabilidade obj);
        bool Put(int id, TipoResponsabilidade obj);
        bool Delete(int id);
    }
}
