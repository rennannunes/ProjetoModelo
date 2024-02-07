namespace ProjetoModelo.Application.DTOs
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string CreatedBy { get; set; }
        public string AlteredBy { get; set; }
    }
}
