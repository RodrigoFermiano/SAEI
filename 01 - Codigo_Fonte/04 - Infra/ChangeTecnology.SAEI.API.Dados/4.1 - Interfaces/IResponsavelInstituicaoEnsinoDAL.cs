using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Dados
{
    public interface IResponsavelInstituicaoEnsinoDAL
    {
        List<ResponsavelInstituicaoEnsino> Get();
        ResponsavelInstituicaoEnsino Get(int id);
        bool Post(ResponsavelInstituicaoEnsino obj);
        bool Put(int id, ResponsavelInstituicaoEnsino obj);
        bool Delete(int id);
    }
}
