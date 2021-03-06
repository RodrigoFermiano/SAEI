﻿using ChangeTecnology.SAEI.API.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeTecnology.SAEI.API.Negocio
{
    public interface IAlunoBLL
    {
        List<Aluno> Get();
        Aluno Get(int id);
        bool Post(Aluno obj);
        bool Put(int id, Aluno obj);
        bool Delete(int id);
    }
}
