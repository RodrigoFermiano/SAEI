using ChangeTecnology.SAEI.API.Dados;
using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public class ResponsavelAlunoBLL : IResponsavelAlunoBLL
    {
        IResponsavelAlunoDAL dados = new ResponsavelAlunoDAL();
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

        public List<ResponsavelAluno> Get()
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

        public ResponsavelAluno Get(int id)
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

        public bool Post(ResponsavelAluno obj)
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

        public bool Put(int id, ResponsavelAluno obj)
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
