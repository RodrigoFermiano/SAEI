using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public interface IInstituicaoEnsinoBLL
    {
        List<InstituicaoEnsino> Get();
        InstituicaoEnsino Get(int id);
        bool Post(InstituicaoEnsino obj);
        bool Put(int id, InstituicaoEnsino obj);
        bool Delete(int id);
    }
}
