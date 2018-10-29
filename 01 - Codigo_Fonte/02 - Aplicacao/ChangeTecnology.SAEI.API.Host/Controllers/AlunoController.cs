using System;
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
    public class AlunoController : ControllerBase
    {

        IAlunoBLL negocio = new AlunoBLL();

        // GET: api/Aluno
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Aluno/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Aluno
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Aluno/5
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
