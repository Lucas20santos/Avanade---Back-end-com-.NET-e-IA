using Microsoft.AspNetCore.Mvc;

namespace FundamentosWebApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHora")] 
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Horas = DateTime.Now.ToLongTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{id}")]
        public IActionResult Apresentar(string id)
        {
            var Id = $"Seu Id: {id}."; 
            return Ok(Id);
        }
    }
}