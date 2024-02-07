namespace ProjetoModelo.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public DateTime Data_Nascimento { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string? AlteredBy { get; private set; }
        public DateTime AlteredDate { get; private set; }


        public Pessoa(string nome, string cpf, string email, string telefone, DateTime data_Nascimento, string createdBy)
        {
            Id = 0; // Id será gerado pelo banco de dados
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Data_Nascimento = data_Nascimento;
            CreatedBy = createdBy;
            CreatedDate = DateTime.Now;
            AlteredDate = DateTime.Now;
        }

        public void AtualizarPessoa(string nome, string cpf, string email, string telefone, DateTime data_Nascimento, string alteredBy)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Data_Nascimento = data_Nascimento;
            AlteredBy = alteredBy;
            AlteredDate = DateTime.UtcNow;
        }

    }
}


