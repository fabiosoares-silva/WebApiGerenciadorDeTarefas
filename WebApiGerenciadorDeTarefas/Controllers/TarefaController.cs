using Microsoft.AspNetCore.Mvc;
using WebApiGerenciadorDeTarefas.Context;
using WebApiGerenciadorDeTarefas.Models;

namespace WebApiGerenciadorDeTarefas.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            return Ok();
        }

        [HttpGet("ObterTodos")]   
        public IActionResult ObterTodos()
        {
            return Ok();
        }

        [HttpGet("ObterPorTítulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            return Ok();
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            return Ok();
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia"});

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            return NoContent();
        }
    }
}
