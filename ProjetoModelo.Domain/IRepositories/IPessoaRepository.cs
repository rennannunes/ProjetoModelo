using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        Pessoa GetById(int id);
        List<Pessoa> GetAll();
        void Add(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(int id);
    }
}
