using Microsoft.AspNetCore.Mvc;
using PessoasApi.Models;
using PessoasApi.Services;

namespace PessoasApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoasController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public ActionResult<PagedList<Pessoa>> Get([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string? filtroNome = null)
        {
            var pessoasPaginadas = _pessoaService.ObterPessoas(pageNumber, pageSize, filtroNome);
            return Ok(pessoasPaginadas);
        }
    }
}
