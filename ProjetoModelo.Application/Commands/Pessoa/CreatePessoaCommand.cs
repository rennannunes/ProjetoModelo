namespace ProjetoModelo.Application.Commands.Pessoa
{
    public class CreatePessoaCommand
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string CreatedBy { get; set; }
    }
}
