using System;
using System.Collections.Generic;
using System.Text;
using ChangeTecnology.SAEI.API.Dados;
using ChangeTecnology.SAEI.API.Entidades;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public class ResponsavelInstituicaoEnsinoBLL : IResponsavelInstituicaoEnsinoBLL
    {
        IResponsavelInstituicaoEnsinoDAL dados = new ResponsavelInstituicaoEnsinoDAL();
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

        public List<ResponsavelInstituicaoEnsino> Get()
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

        public ResponsavelInstituicaoEnsino Get(int id)
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

        public bool Post(ResponsavelInstituicaoEnsino obj)
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

        public bool Put(int id, ResponsavelInstituicaoEnsino obj)
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
