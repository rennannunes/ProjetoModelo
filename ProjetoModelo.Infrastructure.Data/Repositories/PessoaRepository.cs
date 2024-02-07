using Microsoft.EntityFrameworkCore;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces;
using ProjetoModelo.Infrastructure.Data.Context;

namespace ProjetoModelo.Infrastructure.Data.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataContext _dbContext;

        public PessoaRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pessoa GetById(int id)
        {
            return _dbContext.Pessoa.Find(id);
        }

        public List<Pessoa> GetAll()
        {
            return _dbContext.Pessoa.ToList();
        }

        public void Add(Pessoa pessoa)
        {
            _dbContext.Pessoa.Add(pessoa);
            _dbContext.SaveChanges();
        }

        public void Update(Pessoa pessoa)
        {
            _dbContext.Entry(pessoa).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var pessoa = _dbContext.Pessoa.Find(id);
            if (pessoa != null) 
            {
                _dbContext.Pessoa.Remove(pessoa);
                _dbContext.SaveChanges();
            }
        }
    }
}
