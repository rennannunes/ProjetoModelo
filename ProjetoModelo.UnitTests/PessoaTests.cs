using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.UnitTests
{
    public class PessoaTests
    {
        [Fact]
        public void CriarPessoa_ComParametrosValidos_DeveCriarInstancia()
        {
            // Arrange
            var nome = "John Doe";
            var cpf = "87889350007";
            var email = "john.doe@example.com";
            var telefone = "123456789";
            var dataNascimento = new DateTime(1990, 1, 1);
            var createdBy = "system";

            // Act
            var pessoa = new Pessoa(nome, cpf, email, telefone, dataNascimento, createdBy);

            // Assert
            Assert.NotNull(pessoa);
            Assert.Equal(nome, pessoa.Nome);
            Assert.Equal(cpf, pessoa.Cpf);
            Assert.Equal(email, pessoa.Email);
            Assert.Equal(telefone, pessoa.Telefone);
            Assert.Equal(dataNascimento, pessoa.Data_Nascimento);
            // Adicione mais verificações conforme necessário
        }
    }
}