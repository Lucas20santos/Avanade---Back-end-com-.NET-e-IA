using MinhasTarefas.Context;
using MinhasTarefas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MinhasTarefas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController: ControllerBase
    {
        private readonly OrganizadorContext _context;
        public TarefaController(OrganizadorContext context) { _context = context; }

        [HttpGet("ObterTodos")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> ObterTarefa()
        {
            var tarefas = await _context.Tarefas.ToListAsync();

            if (!tarefas.Any()) return NotFound("Nenhuma tarefa encontrada");

            return Ok(tarefas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> ObterId(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);

            if (tarefa == null) return NotFound("Nenhuma tarefa encontrada.");

            return Ok(tarefa);
        }
        
        [HttpGet("ObterPorTitulo")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> ObterTarefa(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo)) return BadRequest("O título para a busca não pode ser vazio.");

            var myTarefas = await _context.Tarefas.Where(x => x.Titulo.ToLower().Contains(titulo.ToLower())).ToListAsync();

            if (!myTarefas.Any()) return NotFound($"Nenhuma tarefa encontrada contendo o termo: '{titulo}'");

            return Ok(myTarefas);
        }
        [HttpGet("ObterPorStatus/{status}")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> GetPorTarefa(StatusTarefa status)
        {
            var tarefas = await _context.Tarefas.Where(x => x.Status == status).ToListAsync();

            if (tarefas == null || tarefas.Any()) return NotFound($"Nenhuma tarefa encontrada com o status: {status}");

            return Ok(tarefas);
        }

        [HttpGet("ObterPorPeriodo")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> GetPorPeriodo([FromQuery] DateTime dataInicio, [FromQuery] DateTime dataFim)
        {
            var dataFimAjustada = dataFim.Date.AddDays(1).AddSeconds(-1);

            var tarefas = await _context.Tarefas.Where(x => x.Date >= dataInicio && x.Date <= dataFimAjustada).OrderBy(x => x.Date).ToListAsync();

            if (!tarefas.Any()) return NotFound("Nenhuma tarefa encontrada neste período.");

            return Ok(tarefas);
        }
        [HttpGet("ObterPorData")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> GetPorData([FromQuery] DateTime data)
        {
            var dataAjustada = data.Date.AddDays(1).AddSeconds(-1);

            var tarefas = await _context.Tarefas.Where(x => x.Date == data).OrderBy(x => x.Date).ToListAsync();

            if (!tarefas.Any()) return NotFound("Nenhuma tarefa encontada neste período");

            return Ok(tarefas);
        }
        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> Atualizar(int id, Tarefa tarefa)
        {
            var my_tarefa = await _context.Tarefas.FindAsync(id);

            if (my_tarefa == null) return NotFound($"Não foi encontrado a terefa de id: {id}");

            my_tarefa.Titulo = tarefa.Titulo;
            my_tarefa.Descicao = tarefa.Descicao;
            my_tarefa.Date = tarefa.Date;
            my_tarefa.Status = tarefa.Status;

            _context.Tarefas.Update(my_tarefa);
            _context.SaveChanges();

            return Ok(my_tarefa);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Tarefa>>> Deletar(int id)
        {
            var my_tarefa = await _context.Tarefas.FindAsync(id);

            if (my_tarefa == null) return NotFound("Não foi encontrado tarefa");

            _context.Tarefas.Remove(my_tarefa);

            return NoContent();
        }

    }    
}
