using System.Collections.Generic;
using System.Linq;
using eletivas.Data;
using eletivas.Models;
using Microsoft.AspNetCore.Mvc;

namespace eletivas.Controllers
{
    [Route("eletivas")]
    [ApiController]
    public class EletivasController: ControllerBase
    {
        private readonly IRepository _repo;
        public EletivasController(IRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult getAllEletivas()
        {
            return Ok(_repo.buscarEletivas());
        }

        [HttpGet("{id}")]
        public IActionResult getEletivaById(int id)
        {
            var eletivaProcurada = _repo.buscarEletivas().FirstOrDefault(x => x.Id == id);
            if (eletivaProcurada == null)
            {
                return BadRequest("Não existe uma eletiva com este Id");
            }
            return Ok(eletivaProcurada);

        }

        [HttpPost]
        public IActionResult insertEletivas(Eletivas eletiva)
        {
            _repo.Adicionar(eletiva);
            if (_repo.SalvarAlteracoes())
            {
                return Created("", eletiva);
            }
            return BadRequest("Não foi possivel inserir eletiva!");
        }
        
        [HttpDelete("{id}")]
        public IActionResult deletarEletivas(int id)
        {
            var eletivaProcurada = _repo.buscarEletivas().FirstOrDefault(x => x.Id == id);
            if (eletivaProcurada == null)
            {
                return BadRequest("Não existe uma eletiva com este id!");
            }
            _repo.Deletar(eletivaProcurada);
            _repo.SalvarAlteracoes();
            return Ok("Deletado!");
        }
    }
}