﻿using System;
using System.Collections.Generic;
using System.Text;
using ChangeTecnology.SAEI.API.Dados;
using ChangeTecnology.SAEI.API.Entidades;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public class TipoPessoaBLL : ITipoPessoaBLL
    {
        ITipoPessoaDAL dados = new TipoPessoaDAL();
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

        public List<TipoPessoa> Get()
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

        public TipoPessoa Get(int id)
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

        public bool Post(TipoPessoa obj)
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

        public bool Put(int id, TipoPessoa obj)
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
