namespace ProjetoModelo.Application.Commands.Pessoa
{
    public class DeletePessoaCommand
    {
        public int PessoaId { get; set; }

        public DeletePessoaCommand(int pessoaId)
        {
            PessoaId = pessoaId;
        }
    }
}
