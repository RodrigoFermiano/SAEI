using System;
using System.Collections.Generic;
using System.Text;
using ChangeTecnology.SAEI.API.Dados;
using ChangeTecnology.SAEI.API.Entidades;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public class EnderecoBLL : IEnderecoBLL
    {
        IEnderecoDAL dados = new EnderecoDAL();

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

        public List<Endereco> Get()
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

        public Endereco Get(int id)
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

        public bool Post(Endereco obj)
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

        public bool Put(int id, Endereco obj)
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
