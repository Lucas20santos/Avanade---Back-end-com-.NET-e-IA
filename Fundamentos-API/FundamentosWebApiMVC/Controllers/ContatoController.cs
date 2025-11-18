using FundamentosWebApiMVC.Context;
using FundamentosWebApiMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FundamentosWebApiMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
        public IActionResult Editar(int Id)
        {
            Contato contato = _context.Contatos.Find(Id);

            if (contato == null) RedirectToAction(nameof(Index));

            return View(contato);
        }
        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var novoContato = _context.Contatos.Find(contato.Id);

            novoContato.Nome = contato.Nome;
            novoContato.Telefone = contato.Telefone;
            novoContato.Ativo = contato.Ativo;

            _context.Contatos.Update(novoContato);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int Id)
        {
            var contato = _context.Contatos.Find(Id);

            if (contato == null) return RedirectToAction(nameof(Index));

            return View(contato);
        }
        public IActionResult Deletar(int Id)
        {
            var contato = _context.Contatos.Find(Id);

            if (contato == null) return RedirectToAction(nameof(Index));

            return View(contato);
        }
        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}