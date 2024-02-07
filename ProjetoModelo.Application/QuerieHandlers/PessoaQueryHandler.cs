using ProjetoModelo.Application.DTOs;
using ProjetoModelo.Application.Mapper;
using ProjetoModelo.Application.Queries.Pessoa;
using ProjetoModelo.Domain.Interfaces;

namespace ProjetoModelo.Application.QuerieHandlers
{
    public class PessoaQueryHandler
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaQueryHandler(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public PessoaDTO Handle(GetPessoaByIdQuery query)
        {
            var pessoa = _pessoaRepository.GetById(query.Id);
            return pessoa != null ? PessoaMapper.MapToDTO(pessoa) : null;
        }

        public List<PessoaDTO> Handle(GetAllPessoasQuery query)
        {
            var pessoas = _pessoaRepository.GetAll();
            var pessoaDTOs = new List<PessoaDTO>();

            if (pessoas != null && pessoas.Any())
            {
                pessoaDTOs = pessoas.Select(p => PessoaMapper.MapToDTO(p)).ToList();
            }
            return pessoaDTOs;
        }
    }
}
