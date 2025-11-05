using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundamentosWebApi.Context;
using FundamentosWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FundamentosWebApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context) { _context = context; }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null) return NotFound();

            return Ok(contato);
        }

        [HttpGet("obterPorNome")]
        public IActionResult ObterContatos(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome)).ToList();

            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null) return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            Console.WriteLine(contatoBanco);

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null) return NotFound();

            _context.Contatos.Remove(contatoBanco);

            return NoContent();

        }
        
    }
}