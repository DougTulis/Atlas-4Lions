using Microsoft.AspNetCore.Mvc;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Projeto_ATLAS_4LIONS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IListarPessoaUseCase _listarPessoaUseCase;
        private readonly ICadastrarPessoaUseCase _cadastrarPessoaUseCase;
        private readonly IDeletarPessoaUseCase _deletarPessoaUseCase;
        private readonly IIncluirCnhUseCase _incluirCnhUseCase;

        public PessoaController(IListarPessoaUseCase listarPessoaUseCase, ICadastrarPessoaUseCase cadastrarPessoaUseCase,IDeletarPessoaUseCase deletarPessoaUseCase, IIncluirCnhUseCase incluirCnhUseCase)
        {
            _listarPessoaUseCase = listarPessoaUseCase;
            _cadastrarPessoaUseCase = cadastrarPessoaUseCase;
            _deletarPessoaUseCase = deletarPessoaUseCase;
            _incluirCnhUseCase = incluirCnhUseCase;
        }


        // GET: api/<PessoaController>
        [HttpGet("historico")]
        public IEnumerable<PessoaDTO> Get()
        {

            var lista = _listarPessoaUseCase.ExecutarDadosCompletos().ToList();


            return lista;
        }

        // GET api/<PessoaController>/5
        [HttpGet("buscar-por-id/{id}")]
        public PessoaDTO? Get(Guid id)
        {
            var pessoaDto = _listarPessoaUseCase.ExecutarRecuperarPorId(id);

            return pessoaDto;
        }

        // POST api/<PessoaController>
        [HttpPost("cadastro")]
        public IActionResult Post([FromBody] PessoaDTO pessoaDto)
        {
          
            var resposta = _cadastrarPessoaUseCase.Executar(pessoaDto);
            if(resposta.Procede == false)
            {
                return BadRequest(resposta);
            }
            return Ok(resposta);

        }

        // PUT api/<PessoaController>/5
        [HttpPut("atualizar-cnh/{id}")]
        public IActionResult AtualizarCNH(Guid id, [FromBody] AtualizarCnhControllerDTO cnhDto)
        {
            
            var pessoaDto = _listarPessoaUseCase.ExecutarRecuperarPorId(id);
            var resposta = _incluirCnhUseCase.Executar(pessoaDto, cnhDto.NumeroCnh, cnhDto.VencimentoCnh);

            if (resposta.Procede == false)
            {
                return BadRequest(resposta);
            }
            return Ok(resposta);
        }

        // DELETE api/<PessoaController>/5
        [HttpDelete("deletar-pessoa/{id}")]
        public void Delete(Guid id)
        {
            var resposta = _deletarPessoaUseCase.Executar(id);
        }
    }
}
