using ProjetoModelo.Application.Commands.Pessoa;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces;

namespace ProjetoModelo.Application.CommandHandlers
{
    public class PessoaCommandHandler
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaCommandHandler(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void HandleCreate(CreatePessoaCommand command)
        {
            var pessoa = new Pessoa(command.Nome
                                   ,command.Cpf
                                   ,command.Email
                                   ,command.Telefone
                                   ,command.Data_Nascimento
                                   ,command.CreatedBy);
            _pessoaRepository.Add(pessoa);
        }


        public void HandleDelete(DeletePessoaCommand command)
        {
            var pessoa = _pessoaRepository.GetById(command.PessoaId);

            if (pessoa != null)
            {
                _pessoaRepository.Delete(pessoa.Id);

            }
        }

        public void HandleUpdate(UpdatePessoaCommand command)
        {
            var pessoa = _pessoaRepository.GetById(command.Id);

            if (pessoa != null)
            {

                pessoa.AtualizarPessoa(command.Nome, command.Cpf, command.Email, command.Telefone, command.Data_Nascimento, command.AlteredBy);

                _pessoaRepository.Update(pessoa);
            }
        }

    }
}
