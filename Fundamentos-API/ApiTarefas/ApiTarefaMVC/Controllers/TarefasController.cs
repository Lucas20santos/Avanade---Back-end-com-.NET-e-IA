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
            // Verificação de validação (sempre bom ter!)
            if (ModelState.IsValid)
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                
                // CORREÇÃO: Redireciona o usuário para o método Index
                return RedirectToAction(nameof(Index)); 
            }
            
            // Se não for válido, retorna a View com o objeto para mostrar erros
            return View(tarefa);
        }
    }
}