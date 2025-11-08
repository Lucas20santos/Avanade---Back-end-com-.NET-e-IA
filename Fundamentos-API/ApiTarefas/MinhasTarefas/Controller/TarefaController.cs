using MinhasTarefas.Context;
using MinhasTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace MinhasTarefas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController: ControllerBase
    {
        private readonly OrganizadorContext _context;
        public TarefaController(OrganizadorContext context) { _context = context; }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }

    }    
}
