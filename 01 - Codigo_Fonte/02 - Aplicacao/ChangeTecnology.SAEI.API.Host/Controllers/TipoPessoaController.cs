﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangeTecnology.SAEI.API.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChangeTecnology.SAEI.API.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPessoaController : ControllerBase
    {
        ITipoPessoaBLL negocio = new TipoPessoaBLL();

        // GET: api/TipoPessoa
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TipoPessoa/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoPessoa
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TipoPessoa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
