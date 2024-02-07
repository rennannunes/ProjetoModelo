using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Application.Commands.Pessoa
{
    public class UpdatePessoaCommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string AlteredBy { get; set; }

    }
}
