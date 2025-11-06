using ApiTarefaMVC.Context;
using ApiTarefaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefaMVC.Controllers
{
    public class TarefasController : Controller
    {
        private readonly OrganizadorContext _context;

        public TarefasController(OrganizadorContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var tarefas = _context.Tarefas.ToList();

            return View(tarefas);
        }
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            _context.Add(tarefa);
            _context.SaveChanges();
            return Created();
        }
    }
}