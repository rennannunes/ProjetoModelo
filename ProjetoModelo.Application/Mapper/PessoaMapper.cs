using ProjetoModelo.Application.DTOs;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Application.Mapper
{
    public class PessoaMapper
    {
        public static PessoaDTO MapToDTO(Pessoa pessoa)
        {
            return new PessoaDTO
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome,
                Cpf = pessoa.Cpf,
                Email = pessoa.Email,
                Telefone = pessoa.Telefone,
                Data_Nascimento = pessoa.Data_Nascimento,
                CreatedBy = pessoa.CreatedBy,
                AlteredBy = pessoa.AlteredBy
            };
        }
    }
}
