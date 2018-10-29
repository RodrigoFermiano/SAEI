using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Dados
{
    public interface ITipoPessoaDAL
    {
        List<TipoPessoa> Get();
        TipoPessoa Get(int id);
        bool Post(TipoPessoa obj);
        bool Put(int id, TipoPessoa obj);
        bool Delete(int id);
    }
}
