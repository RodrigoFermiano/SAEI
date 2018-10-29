using System;
using System.Collections.Generic;
using System.Text;
using ChangeTecnology.SAEI.API.Dados;
using ChangeTecnology.SAEI.API.Entidades;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public class MotoristaBLL : IMotoristaBLL
    {
        IMotoristaDAL dados = new MotoristaDAL();
        public bool Delete(int id)
        {
            try
            {
                return dados.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Motorista> Get()
        {
            try
            {
                return dados.Get();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Motorista Get(int id)
        {
            try
            {
                return dados.Get(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Post(Motorista obj)
        {
            try
            {
                return dados.Post(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Put(int id, Motorista obj)
        {
            try
            {
                return dados.Put(id, obj);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
