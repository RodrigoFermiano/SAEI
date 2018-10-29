using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Dados
{
    public interface IVeiculoDAL
    {
        List<Veiculo> Get();
        Veiculo Get(int id);
        bool Post(Veiculo obj);
        bool Put(int id, Veiculo obj);
        bool Delete(int id);
    }
}
