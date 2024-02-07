using Microsoft.EntityFrameworkCore;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infrastructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*set default string length 100 and column type varchar*/

            modelBuilder.Entity<Pessoa>()
                .Property(s => s.Data_Nascimento)
                .HasColumnName("Data_Nascimento")
                .HasColumnType("datetime");

            modelBuilder.Entity<Pessoa>()
                .Property(s => s.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime");

            modelBuilder.Entity<Pessoa>()
                .Property(s => s.AlteredDate)
                .HasColumnName("AlteredDate")
                .HasColumnType("datetime");
        }

    }
}
