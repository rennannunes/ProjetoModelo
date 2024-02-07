using Microsoft.AspNetCore.Mvc;
using ProjetoModelo.Application.CommandHandlers;
using ProjetoModelo.Application.Commands.Pessoa;
using ProjetoModelo.Application.QuerieHandlers;
using ProjetoModelo.Application.Queries.Pessoa;

namespace ProjetoModelo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaCommandHandler _pessoaCommandHandler;
        private readonly PessoaQueryHandler _pessoaQueryHandler;

        public PessoaController(PessoaQueryHandler pessoaQueryHandler
                               , PessoaCommandHandler pessoaCommandHandler)
        {
            _pessoaCommandHandler = pessoaCommandHandler;
            _pessoaQueryHandler = pessoaQueryHandler;

        }


        [HttpGet("{id}")]
        public IActionResult GetPessoaById(int id)
        {
            var query = new GetPessoaByIdQuery { Id = id };
            var pessoa = _pessoaQueryHandler.Handle(query);

            if (pessoa != null)
            {
                return Ok(pessoa);
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult GetAllPessoas()
        {
            try
            {
                var query = new GetAllPessoasQuery();
                var pessoa = _pessoaQueryHandler.Handle(query);

                return Ok(pessoa);
            }
            catch (Exception ex)
            {
                // Log de erro, tratamento adequado, etc.
                return StatusCode(500, "Erro interno no servidor");
            }
        }

        [HttpPost]
        public IActionResult CreatePessoa([FromBody] CreatePessoaCommand command)
        {
            _pessoaCommandHandler.HandleCreate(command);

            return Ok(command);
        }


        [HttpPut("{id}")]
        public IActionResult UpdatePessoa(int id, [FromBody] UpdatePessoaCommand command)
        {
            try
            {
                command.Id = id;
                _pessoaCommandHandler.HandleUpdate(command);
                return Ok("Pessoa atualizada com sucesso.");
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Erro ao atualizar pessoa: {ex.Message}");
            }
        }


        [HttpDelete]
        public IActionResult DeletePessoa([FromBody] DeletePessoaCommand command)
        {
            _pessoaCommandHandler.HandleDelete(command);

            return Ok("Excluido com sucesso!");
        }

    }
}
